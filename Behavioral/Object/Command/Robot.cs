namespace Command
{
    public class Robot
    {
        public void Start() { }
        public void Stop()  { }
        public void Restart()
        {
            this.Stop();
            this.Start();
        }
        public void Walk() { }        
    }
}