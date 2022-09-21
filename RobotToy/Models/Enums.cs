using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RobotToy.Models
{
    public enum Face {
        [Display(Name = "EAST")]
        EAST = 0,
        [Display(Name = "SOUTH")]
        SOUTH = 1,
        [Display(Name = "WEST")]
        WEST = 2,
        [Display(Name = "NORTH")]
        NORTH = 3 };

    public enum Direction { LEFT = -1, RIGHT = 1};
}
