using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepRacer
{
    class DMath
    {
        /**
         * angle1, angle2의 차이를 -180 ~ 180 사이의 각도로 리턴한다.
         */
        public static double GetAngleDiff(double angle1, double angle2)
        {
            return Get180Angle(angle1 - angle2);
        }

        // angle1 과 angle2의 중간 각도를 리턴한다.
        public static double GetMidAngle(double angle1, double angle2)
        {
            return angle1 + GetAngleDiff(angle2, angle1) / 2;

        }

        // angle을 0~359.9999... 의 각도로 변환한다
        public static double Get360Angle(double angle)
        {
            while (angle >= 360)
                angle -= 360;
            while (angle < 0)
                angle += 360;
            return angle;
        }

        // angle을 -179.9999.. ~ 180 의 각도로 변환한다.
        public static double Get180Angle(double angle)
        {
            while (angle > 180)
                angle -= 360;
            while (angle <= -180)
                angle += 360;
            return angle;
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

        /**
         * lpt1에서 lpt2방향으로 distance만큼 이동한 후의 위치를 구한다
         */
        public static RPoint GetRPointOfDistance(RPoint lpt1, RPoint lpt2, double distance)
        {
            var angle = lpt1.GetAngle(lpt2);
            var dpt = new RPoint(lpt1.X + distance, lpt1.Y);
            return Rotate(lpt1, dpt, angle);
        }

        public static RPoint GetMiddle(RPoint pt1, RPoint pt2)
        {
            return new RPoint((pt1.X + pt2.X) / 2, (pt1.Y + pt2.Y) / 2);
        }

        /**
         * waypoints에서 pt에 가장 가까운 2개의 점을 리턴한다.
         * 보통은 pt의 앞뒤로 하나씩 나오니 (n, n+1) 이 리턴된다.
         * 그런데 위치가 애매한 경우 (n, n) 이 나올 수도 있다.
         */
        public static (int prev, int next) FindClosestWaypointIndex(RPoint pt, List<RPoint> waypoints)
        {
            (int prev, int next) closestIndex = (-1, -1); // 그냥 제일 가까운 index
            (int prev, int next) centeredIndex = (-1, -1); // (prev, index) 중심에 제일 가까운 index

            var oldDist = Double.MaxValue; // pt에서 waypoint prev까지의 거리
            var oldCenterDist = Double.MaxValue; // pt가 waypoint line 중심에서 얼마나 벗어나 있는가
            for (var i = 0; i < waypoints.Count - 1; i++)
            {
                RPoint prev = waypoints[i];
                RPoint next = waypoints[i + 1];

                double angle = prev.GetAngle(next);

                RPoint rotatedNext = DMath.Rotate(prev, next, -angle);
                RPoint rotatedPt = DMath.Rotate(prev, pt, -angle);
                if (rotatedPt.X <= rotatedNext.X)
                {
                    var cross = pt.GetClosestPointFromLine(prev, next);
                    var middle = GetMiddle(prev, next);
                    var newDist = prev.DistanceTo(pt);

                    if (closestIndex.next < 0 || newDist < oldDist)
                    {
                        oldDist = newDist;
                        if (prev.X <= rotatedPt.X)
                        {
                            closestIndex = (i, i + 1);
                        }
                        else
                        {
                            closestIndex = (i, i);
                        }
                    }

                    var newCenterDist = cross.DistanceTo(middle);
                    if (prev.X <= rotatedPt.X && newCenterDist < oldCenterDist && newDist < 0.7)
                    {
                        centeredIndex = (i, i + 1);
                        oldCenterDist = newCenterDist;
                    }
                }
            }

            if (closestIndex.prev == -1)
                throw new Exception($"cannot find closest waypoint of {pt}");

            if (centeredIndex.prev >= 0)
                return centeredIndex;
            else
                return closestIndex;
        }
        
        /**
         * pt에서 index에 해당하는 waypoint 라인까지의 거리
         * pt가 waypoint 진행방향의 왼쪽에 있으면 마이너스 값을 리턴한다.
         */
        public static double GetDistanceToWaypoint(RPoint pt, List<RPoint> waypoints, (int prev, int next) index)
        {
            if (index.prev == index.next)
            {
                var distance = pt.DistanceTo(waypoints[index.prev]);
                var trackDirection = GetWaypointDirection(waypoints, index, pt);
                var rotatedPt = pt - waypoints[index.prev];
                rotatedPt = Rotate(new RPoint(), rotatedPt, -trackDirection);
                var isLeft = rotatedPt.Y >= 0;
                return isLeft ? -distance : distance;
            }
            else
            {
                return pt.DistanceToLine(waypoints[index.prev], waypoints[index.next]);
            }
        }

        public static int GetNextWaypointIndex(List<RPoint> waypoints, int index)
        {
            index++;
            if (index == waypoints.Count)
                index = 1;
            return index;
        }

        public static int GetPrevWaypointIndex(List<RPoint> waypoints, int index)
        {
            index--;
            if (index < 0)
                index = waypoints.Count - 2;
            return index;
        }

        /**
         * waypoints 상에서 pt에서 가장 가까운 부분의 방향.
         * index는 pt에서 가장 가까운 앞뒤 waypoint
         * distance가 0이 아니면 앞/뒤로 distance 이동한 다음에 방향을 구한다.
         */
        public static double GetWaypointDirection(List<RPoint> waypoints, (int prev, int next) index, RPoint pt, double distance = 0)
        {
            
            RPoint cross;
            if (index.prev == index.next)
                cross = waypoints[index.prev];
            else
                cross = pt.GetClosestPointFromLine(waypoints[index.prev], waypoints[index.next]);

            cross = GetRPointOnWaypoint(waypoints, (distance >= 0 ? index.next : index.prev), distance, cross);

            RPoint ptPrev = GetRPointOnWaypoint(waypoints, index.prev, -0.15, cross);
            RPoint ptNext = GetRPointOnWaypoint(waypoints, index.next, 0.15, cross);
            return ptPrev.GetAngle(ptNext);
        }

        /**
         * waypoints 상의 pt에서 시작해 앞/뒤로 distance 떨어진 곳의 점을 구한다.
         * distance > 0 이면 앞으로, 아니면 뒤쪽 방향으로 이동.
         * pt는 반드시 waypoint 를 잇는 라인 위에 있어야 한다.
         */
        public static RPoint GetRPointOnWaypoint(List<RPoint> waypoints, int index, double distance, RPoint pt)
        {
            if (distance == 0)
                return pt;

            var absDistance = Math.Abs(distance);

            double distanceSum = 0;
            do
            {
                double currentDistance = pt.DistanceTo(waypoints[index]);
                if (distanceSum + currentDistance >= absDistance)
                    break;

                distanceSum += currentDistance;
                pt = waypoints[index];

                if (distance > 0)
                    index = GetNextWaypointIndex(waypoints, index);
                else
                    index = GetPrevWaypointIndex(waypoints, index);
            }
            while (true);

            return GetRPointOfDistance(pt, waypoints[index], absDistance - distanceSum);
        }
    }
}
