namespace State
{
    public class Player
    {
        private State? _state = null;

        public Player( State state)
        {
            this.TransitionTo( state);
            
        }

        public void Status()
        {
            this._state?.Status();
        }

        public void TransitionTo( State state)
        {
            System.Console.WriteLine($"Transition to {state.GetType().Name}.");
            this._state = state;
            this._state.SetPlayer(this);
        }
    }

}