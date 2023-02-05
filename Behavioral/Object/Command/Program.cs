using Command;

Robot robot = new();

RobotCommand robotCommand;
robotCommand = new StartCommand(robot);
robotCommand.Execute();
robotCommand = new StopCommand(robot);
robotCommand.Execute();
robotCommand = new RestartCommand(robot);
robotCommand.Execute();
robotCommand = new WalkCommand(robot);
robotCommand.Execute();
