using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepRacer
{
    public class RPointJsonConverter : JsonConverter<RPoint>
    {
        public override RPoint ReadJson(JsonReader reader, Type objectType, RPoint existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var array = JArray.Load(reader);
            /*
            if (!reader.Read())
                throw new Exception("unexpected end of json");

            if (reader.TokenType != JsonToken.StartArray)
                throw new Exception($"expected start array: {reader.TokenType}");
                */

            double x = array[0].ToObject<double>();
            double y = array[1].ToObject<double>();

            /*
            if (!reader.Read())
                throw new Exception("unexpected end of json");

            if (reader.TokenType != JsonToken.EndArray)
                throw new Exception($"expected end array: {reader.TokenType}");
                */

            return new RPoint(x, y);
        }

        public override void WriteJson(JsonWriter writer, RPoint value, JsonSerializer serializer)
        {
            writer.WriteStartArray();
            writer.WriteValue(value.X);
            writer.WriteValue(value.Y);
            writer.WriteEndArray();
        }
    }

    [JsonConverter(typeof(RPointJsonConverter))]
    public struct RPoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static RPoint From(Point pt)
        {
            return new RPoint(ToRacerX(pt.X), ToRacerY(pt.Y));
        }

        public RPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point toPoint()
        {
            return new Point(ToScreenX(X), ToScreenY(Y));
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj.GetType() != this.GetType())
                return false;

            var dst = (RPoint)obj;
            return this.X == dst.X && this.Y == dst.Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        public override string ToString()
        {
            return $"X={X}, Y={Y}";
        }

        public static bool operator ==(RPoint left, RPoint right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(RPoint left, RPoint right)
        {
            return !left.Equals(right);
        }

        public static RPoint operator +(RPoint left, RPoint right)
        {
            return new RPoint(left.X + right.X, left.Y + right.Y);
        }

        public static RPoint operator -(RPoint left, RPoint right)
        {
            return new RPoint(left.X - right.X, left.Y - right.Y);
        }

        public const int SCREEN_Y_TOP = 500 * SCALE;
        public const int SCALE = 1;

        public static int ToScreenX(double x) { return (int)(x * SCALE * 100); }
        public static int ToScreenY(double y) { return SCREEN_Y_TOP - (int)(y * SCALE * 100); }
        public static double ToRacerX(int x) { return (double)x / (SCALE * 100); }
        public static double ToRacerY(int y) { return (double)(SCREEN_Y_TOP - y) / (SCALE * 100); }

        public double DistanceTo(RPoint pt)
        {
            var vec = pt - this;
            return Math.Sqrt(vec.X * vec.X + vec.Y * vec.Y);
        }

        /**
         * pt와 lpt1 -- lpt2 라인의 거리를 측정한다
         * pt가 lpt1-lpt2의 왼쪽이면 마이너스, 오른쪽이면 플러스 값이 리턴된다.
         */
        public double DistanceToLine(RPoint lpt1, RPoint lpt2)
        {
            return ((lpt2.Y - lpt1.Y) * this.X - (lpt2.X - lpt1.X) * this.Y + lpt2.X * lpt1.Y - lpt2.Y * lpt1.X) /
                Math.Sqrt(Math.Pow(lpt2.Y - lpt1.Y, 2) + Math.Pow(lpt2.X - lpt1.X, 2));
        }

        // 이 점과 pt가 이루는 각도를 리턴한다.
        public double GetAngle(RPoint pt)
        {
            double radian = Math.Atan2(pt.Y - this.Y, pt.X - this.X);
            return radian * 180 / Math.PI;
        }

        /**
         * 현재 점이 lpt1, lpt2를 잇는 선의 왼쪽에 있는지 판단한다.
         */
        public bool IsLeftOfLine(RPoint lpt1, RPoint lpt2)
        {
            var d = (X - lpt1.X) * (lpt2.Y - lpt1.Y) - (Y - lpt1.Y) * (lpt2.X - lpt1.X);
            return d < 0;
        }

        /**
         * 현재 점이 lpt1, lpt2를 잇는 선과 직교하는 포인트를 구한다.
         */
        public RPoint GetClosestPointFromLine(RPoint lpt1, RPoint lpt2)
        {
            if (lpt1 == lpt2)
                return lpt1;

            var px = lpt2.X - lpt1.X;
            var py = lpt2.Y - lpt1.Y;
            var dab = px * px + py * py;
            var u = ((X - lpt1.X) * px + (Y - lpt1.Y) * py) / dab;
            return new RPoint(lpt1.X + u * px, lpt1.Y + u * py);
        }
    }
}
