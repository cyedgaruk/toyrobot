using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotToy.Models.Boards
{
    public class SquareBoard : Board
    {
        protected override int _width { get; set; } = 5;
        protected override int _height { get; set; } = 5;


    }
}
