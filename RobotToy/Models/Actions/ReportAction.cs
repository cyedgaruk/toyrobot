using RobotToy.Extensions;
using RobotToy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotToy.Models.Actions
{
    public class ReportAction : IAction
    {

        public (int, int, Face) DoAction((int X, int Y, Face Face) currentPosition, (int Width, int Height) dimension)
        {
            //print position and return current position
            Console.WriteLine($"Output: {currentPosition.X},{currentPosition.Y},{currentPosition.Face.GetDisplayName()}");
            return currentPosition;
        }

    }
}
