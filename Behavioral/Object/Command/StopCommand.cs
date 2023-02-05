namespace Command
{
    public class StopCommand : RobotCommand
    {
        public StopCommand( Robot robot )
        {
            this.Robot = robot;
        }

        public override void Execute()
        {
            System.Console.WriteLine("Stopping......");
            Robot?.Stop();
        }
        
    }
}