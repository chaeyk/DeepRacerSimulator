﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepRacer
{
    struct RPoint
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

        public double DistanceTo(RPoint pt)
        {
            var vec = pt - this;
            return Math.Sqrt(vec.X * vec.X + vec.Y * vec.Y);
        }

        // 이 점과 pt가 이루는 각도를 리턴한다.
        public double GetAngle(RPoint pt)
        {
            double radian = Math.Atan2(pt.Y - this.Y, pt.X - this.X);
            return radian * 180 / Math.PI;
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

        public const int SCREEN_Y_TOP = 500;

        public static int ToScreenX(double x) { return (int)(x * 100); }
        public static int ToScreenY(double y) { return SCREEN_Y_TOP - (int)(y * 100); }
        public static double ToRacerX(int x) { return (double)x / 100; }
        public static double ToRacerY(int y) { return (double)(SCREEN_Y_TOP - y) / 100; }

        /**
         * pt와 lpt1 -- lpt2 라인의 거리를 측정한다
         */
        public double DistanceToLine(RPoint lpt1, RPoint lpt2)
        {
            double dx = lpt2.X - lpt1.X;
            double dy = lpt2.Y - lpt1.Y;
            if (dx == 0 && dy == 0)
            {
                // It's a point not a line segment
                dx = this.X - lpt1.X;
                dy = this.Y - lpt1.Y;
                return Math.Sqrt(dx * dx + dy * dy);
            }

            // Calculate the t that minimizes the distance
            double t = ((this.X - lpt1.X) * dx + (this.Y - lpt1.Y) * dy) / (dx * dx + dy * dy);

            // See if this represents one of the segment's
            // end points or a point in the middle
            if (t < 0)
            {
                dx = this.X - lpt1.X;
                dy = this.Y - lpt1.Y;
            }
            else if (t > 1)
            {
                dx = this.X - lpt2.X;
                dy = this.Y - lpt2.Y;
            }
            else
            {
                dx = this.X - (lpt1.X + t * dx);
                dy = this.Y - (lpt1.Y + t * dy);
            }

            return Math.Sqrt(dx * dx + dy * dy);
        }

        /**
         * 현재 점이 lpt1, lpt2를 잇는 선의 왼쪽에 있는지 판단한다.
         */
        public bool IsLeftOfLine(RPoint lpt1, RPoint lpt2)
        {
            var d = (X - lpt1.X) * (lpt2.Y - lpt1.Y) - (Y - lpt1.Y) * (lpt2.X - lpt1.X);
            return d > 0;
        }

        /**
         * center를 중심으로 pt를 angle만큼 회전시킨다
         */
        public static RPoint Rotate(RPoint center, RPoint pt, double angle)
        {
            double radians = angle * Math.PI / 180;
            double sin = Math.Sin(radians);
            double cos = Math.Cos(radians);

            // Translate point back to origin
            pt.X -= center.X;
            pt.Y -= center.Y;

            // Rotate point
            double xnew = pt.X * cos - pt.Y * sin;
            double ynew = pt.X * sin + pt.Y * cos;

            // Translate point back
            return new RPoint(xnew + center.X, ynew + center.Y);
        }
    }
}