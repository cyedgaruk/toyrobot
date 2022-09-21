using RobotToy.Models;
using RobotToy.Models.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RobotToy.Services
{
    public class InputValidator
    {
        public static IAction Validate(string input)
        {
            //split arguments
            string[] inputArgs = input.ToUpper().Split(' ');

            if(inputArgs.Length >= 1)
            {
                switch(inputArgs[0])
                {
                    case "PLACE":
                        if(inputArgs.Length == 2)
                        {
                            //get position parameters
                            string[] parameters = inputArgs[1].Split(',');
                            if(parameters.Length == 3)
                            {
                                if (int.TryParse(parameters[0], out int x) && int.TryParse(parameters[1], out int y) && Enum.TryParse(parameters[2], out Face f)) {
                                    return new PlaceAction(x, y, f);
                                }
                            }
                        }
                        break;
                    case "MOVE":
                        return new MoveAction();
                    case "LEFT":
                    case "RIGHT":
                        Enum.TryParse(inputArgs[0], out Direction d);
                        return new TurnAction(d);
                    case "REPORT":
                        return new ReportAction();
                }
            }
            //if not fall into any category, return invalid action
            return new InvalidAction();
        }
    }
}
