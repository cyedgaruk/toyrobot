using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotToy.Models.Actions
{
    public interface IAction
    {
        public (int, int, Face) DoAction((int X, int Y, Face Face) currentPosition, (int Width, int Height) dimension);
    }
}
