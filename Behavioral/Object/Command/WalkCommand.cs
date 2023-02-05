namespace Command
{
    public class WalkCommand : RobotCommand
    {
        public WalkCommand( Robot robot )
        {
            this.Robot = robot;
        }

        public override void Execute()
        {
            System.Console.WriteLine("Walking.......");
            Robot?.Walk();
        }
    }
}