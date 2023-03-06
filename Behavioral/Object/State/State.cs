namespace State
{
    public abstract class State
    {
        protected Player? Player{get; set;}

        public void SetPlayer( Player player)
        {
            this.Player = player;
        }

        public abstract void Status();
    }

}