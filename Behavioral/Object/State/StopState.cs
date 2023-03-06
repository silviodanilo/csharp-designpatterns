namespace State
{
    public class StopState : State
    {
        public override void Status()
        {
            System.Console.WriteLine("Stopped");
        }
    }

}