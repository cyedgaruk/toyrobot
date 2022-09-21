using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotToy.Models.Boards
{
    public abstract class Board
    {
        protected virtual int _width { get; set; } = 0;
        protected virtual int _height {get; set; } = 0;
        public (int Width, int Height) Dimension => (_width, _height);
    }
}
