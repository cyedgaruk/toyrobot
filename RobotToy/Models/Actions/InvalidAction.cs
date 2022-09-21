using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotToy.Models.Actions
{
    public class InvalidAction : IAction
    {
        public (int, int, Face) DoAction((int X, int Y, Face Face) currentPosition, (int Width, int Height) dimension)
        {
            //print error message and return current position
            Console.WriteLine("Invalid Command");
            return currentPosition;
        }
    }
}
