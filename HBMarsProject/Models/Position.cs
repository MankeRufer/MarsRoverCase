using HBMarsProject.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBMarsProject.Models
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public DirectionEnum Direction { get; set; }
    }
}
