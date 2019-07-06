using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepRacer
{
    class Setting
    {
        public int MaxSteer { get; set; } = 20;
        public int SteerSteps { get; set; } = 5;
        public int MaxSpeed { get; set; } = 6;
        public int SpeedStep { get; set; } = 3;
    }
}
