namespace Command
{
    public class RestartCommand : RobotCommand
    {
        public RestartCommand( Robot robot)
        {
            this.Robot = robot;
        }
        public override void Execute()
        {
             System.Console.WriteLine("Restarting....");
             Robot?.Restart();
        }
    }
}