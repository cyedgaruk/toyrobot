using RobotToy.Models;
using RobotToy.Models.Actions;
using RobotToy.Models.Boards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotToy.Services
{
    public class RobotMover
    {
        private readonly ToyRobot _robot;
        private readonly Board _board;

        public RobotMover(ToyRobot robot, Board board)
        {
            _robot = robot;
            _board = board;
        }

        public void Execute(IAction action)
        {
            //check if first command is PLACE action, otherwise ignore
            if (_robot.IsPlaced || action is PlaceAction)
            {
                //update robot status
                _robot.IsPlaced = true;
                _robot.CurrentPosition = action.DoAction(_robot.CurrentPosition, _board.Dimension);
            }
        }
    }
}
