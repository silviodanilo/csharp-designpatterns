namespace Command
{
    public class StartCommand : RobotCommand
    {
        public StartCommand( Robot robot )
        {
            this.Robot = robot;
        }

        public override void Execute()
        {
            System.Console.WriteLine("Starting......");
            Robot?.Start();
        }

    }
}