using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RobotToy.Models;
using RobotToy.Models.Actions;
using RobotToy.Models.Boards;
using RobotToy.Services;


//initialize board configuration
Board board = new SquareBoard();

//initialize robot
ToyRobot robot = new ToyRobot();

//initialize robot helper class
RobotMover mover = new RobotMover(robot, board);

IAction action;

Console.WriteLine("Please enter command: [PLACE]/[MOVE]/[LEFT]/[RIGHT]/[REPORT]");

do
{
    
    //get and execute user action
    string input = Console.ReadLine();
    action = InputValidator.Validate(input);
    mover.Execute(action);

} while (!(action is ReportAction));


