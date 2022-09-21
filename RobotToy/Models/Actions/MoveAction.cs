using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotToy.Models.Actions
{
    public class MoveAction : IAction
    {
        private const int _moveStep = 1;

        public (int, int, Face) DoAction((int X, int Y, Face Face) currentPosition, (int Width, int Height) dimension)
        {
            //get upcoming movement
            (int xMovement, int yMovement) movement = (0, 0);
            switch (currentPosition.Face)
            {
                case Face.EAST:
                    movement = (1, 0);
                    break;
                case Face.WEST:
                    movement = (-1, 0);
                    break;
                case Face.NORTH:
                    movement = (0, 1);
                    break;
                case Face.SOUTH:
                    movement = (0, -1);
                    break;
            }

            //get possible new position
            var newPosition = (currentPosition.X + movement.xMovement, currentPosition.Y + movement.yMovement, currentPosition.Face);

            //if exceeded the table, ignore and return original position
            if (newPosition.Item1 < 0 || newPosition.Item1 >= dimension.Width)
                return currentPosition;
            if (newPosition.Item2 < 0 || newPosition.Item2 >= dimension.Height)
                return currentPosition;

            //return new position
            return newPosition;
        }
    }
}
