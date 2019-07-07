using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepRacer
{
    public class Setting
    {
        public int MaxSteer { get; set; } = 20;
        public int SteerSteps { get; set; } = 5;
        public int MaxSpeed { get; set; } = 6;
        public int SpeedSteps { get; set; } = 3;

        public static Setting Load()
        {
            try
            {
                return JsonConvert.DeserializeObject<Setting>(File.ReadAllText(GetFilePath()));
            }
            catch (FileNotFoundException)
            {
                return new Setting();
            }
        }

        public void Save()
        {
            var json = JsonConvert.SerializeObject(this);
            var buffer = Encoding.UTF8.GetBytes(json);
            using (FileStream fs = new FileStream(GetFilePath(), FileMode.Create, FileAccess.Write, FileShare.Read, bufferSize: 4096, useAsync: false))
            {
                fs.Write(buffer, 0, buffer.Length);
            }
        }

        public static String GetPath()
        {
            var path = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\DeepRacerSimulator";
            Directory.CreateDirectory(path);
            return path;
        }

        public static String GetFilePath()
        {
            return $"{GetPath()}\\settings.json";
        }
    }
}
