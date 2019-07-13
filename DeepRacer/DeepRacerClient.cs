using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeepRacer
{
    struct InitializingData
    {
        [JsonProperty]
        public const string op = "InitializingData";
        public string rf { get; set; }
        public List<RPoint> waypoints { get; set; }
        public double track_width { get; set; }
        public List<double> speeds { get; set; }
    }

    struct InitializedData
    {
        [JsonProperty]
        public const string op = "InitializedData";
        public List<RPoint> optimal_waypoints { get; set; }
    }

    struct RewardRequest
    {
        [JsonProperty]
        public const string op = "RewardRequest";
        public bool all_wheels_on_track { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public double distance_from_center { get; set; }
        public bool is_left_of_center { get; set; }
        public double heading { get; set; }
        public double progress { get; set; }
        public int steps { get; set; }
        public double speed { get; set; }
        public double steering_angle { get; set; }
        public double track_width { get; set; }
        public int[] closest_waypoints { get; set; }
        public bool is_reversed { get; set; }
    }

    struct RewardResponse
    {
        public string op { get; set; }
        public double reward { get; set; }
        public Dictionary<String, Double> ext_rewards { get; set; }
    }

    struct Ping
    {
        [JsonProperty]
        public const string op = "Ping";
    }

    struct Pong
    {
        public string op { get; set; }
    }

    class DeepRacerClient : IDisposable
    {
        private TcpClient _client = new TcpClient();
        private NetworkStream _stream = null;
        private StreamWriter _writer = null;
        private StreamReader _reader = null;

        public bool Connected
        {
            get { return _client?.Connected ?? false; }
        }

        public DeepRacerClient()
        {
            _client = new TcpClient();
        }

        public async Task ConnectAsync(IPAddress addr, int port, CancellationToken ct)
        {
            if (Connected)
                return;

            var ep = new IPEndPoint(addr, port);
            await _client.ConnectAsync(addr, port);
            _stream = _client.GetStream();
            _writer = new StreamWriter(_stream, new UTF8Encoding(false));
            _reader = new StreamReader(_stream, new UTF8Encoding(false));
        }

        public void Close()
        {
            if (!Connected)
                return;

            _client.Close();
        }

        public void Dispose()
        {
            _reader?.Dispose();
            _reader = null;
            _writer?.Dispose();
            _writer = null;
            _stream?.Dispose();
            _stream = null;
            _client.Close();
            _client = null;
        }

        public async Task<InitializedData> SendInitializingDataAsync(InitializingData initializingData)
        {
            await SendLineAsync(JsonConvert.SerializeObject(initializingData));
            var responseStr = await _reader.ReadLineAsync();
            return JsonConvert.DeserializeObject<InitializedData>(responseStr);
        }

        public async Task<RewardResponse> GetRewardAsync(RewardRequest request)
        {
            var requestStr = JsonConvert.SerializeObject(request);

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            await SendLineAsync(requestStr);
            var responseStr = await _reader.ReadLineAsync();

            stopwatch.Stop();
            var elapsed = stopwatch.ElapsedMilliseconds;
            if (elapsed > 50)
            {
                Console.WriteLine($"executed for {stopwatch.ElapsedMilliseconds} ms");
            }
            return JsonConvert.DeserializeObject<RewardResponse>(responseStr);
        }

        public async Task Ping()
        {
            var requestStr = JsonConvert.SerializeObject(new Ping());
            await SendLineAsync(requestStr);
            var responseStr = await _reader.ReadLineAsync();
            var response = JsonConvert.DeserializeObject<Pong>(responseStr);

            if (response.op != "Pong")
            {
                Console.WriteLine($"Invalid pong: {responseStr}");
                Close();
            }
        }

        private async Task SendLineAsync(string line)
        {
            await _writer.WriteLineAsync(line);
            await _writer.FlushAsync();
        }
    }
}
