using RobotToy.Models.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RobotToy.Models
{

    public class ToyRobot
    {
        private int _x { get; set; }
        private int _y { get; set; }

        private Face _face { get; set; }


        public int X => _x;
        public int Y => _y;
        public Face Face => _face;


        public bool IsPlaced { get; set; } = false;

        public ToyRobot()
        {
            _x = 0;
            _y = 0;
            _face = Face.EAST;
        }

        public (int X, int Y, Face Face) CurrentPosition
        {
            get
            {
                return (_x, _y, _face);
            }
            set
            {
                (_x, _y, _face) = (value.X, value.Y, value.Face);
            }
        }
    }
}
            