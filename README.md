# toyrobot
Instruction to run the program:
1) Start running with visual studio, or
2) Open windows command prompt and execute RobotToy.exe file

Program design:
- Board: board represents the game table with dimension configured inside. SquareBoard is the implementation of it for Square table, if any other configurations (e.g. obstructions) needed to add into the game in the future, we can create a new class with other configurations to inherience from the Board class
- Action: All actions implement the IAction interface and share the same method "DoAction" to perform specific movmenet of each action, it is easy to add other Action in the future by implementing IAction with a new class.
- InputValidator: a helper class to convert text command into appropiate action object
- RobotMover: a helper class to execute the "DoAction" method of different type of Action object

Acceptable command (case insenitive):
1) PLACE X,Y,F: 
	place the robot at specific location and orientation
	- e.g. PLACE 1,2,NORTH
2) MOVE
	move the robot 1 step forward
3) LEFT
	turn the robot to 90 degree left
4) RIGHT
	turn the robot to 90 degree right
5) REPORT
	print the current position of the robot to console, then quit the game
