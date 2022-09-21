using RobotToy.Extensions;
using RobotToy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotToy.Models.Actions
{
    public class TurnAction : IAction
    {
        private readonly Direction _direction;

        public Direction Direction => _direction;

        public TurnAction(Direction direction)
        {
            _direction = direction;
        }


        public (int, int, Face) DoAction((int X, int Y, Face Face) currentPosition, (int Width, int Height) dimension)
        {
            var newFace = currentPosition.Face;

            //get new orientation
            switch(_direction)
            {
                case Direction.LEFT:
                    newFace = currentPosition.Face.Previous();
                    break;
                case Direction.RIGHT:
                    newFace = currentPosition.Face.Next();
                    break;

            }

            //return new position
            return (currentPosition.X, currentPosition.Y, newFace);
        }

    }
}
