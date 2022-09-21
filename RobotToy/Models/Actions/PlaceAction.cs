using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotToy.Models.Actions
{
    public class PlaceAction : IAction
    {
        private readonly int _x;
        private readonly int _y;
        private readonly Face _face;

        public int X => _x;
        public int Y => _y;
        public Face Face => _face;


        public PlaceAction(int x, int y, Face face)
        {
            _x = x;
            _y = y;
            _face = face;
        }

        public (int, int, Face) DoAction((int X, int Y, Face Face) currentPosition, (int Width, int Height) dimension)
        {
            //if exceeded the table, ignore and return original position
            if (_x < 0 || _x >= dimension.Width)
                return currentPosition;
            if (_y < 0 || _y >= dimension.Height)
                return currentPosition;

            //return new position
            return (_x, _y, _face);
        }


    }
}
