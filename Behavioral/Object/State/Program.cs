using State;

State.State stop = new StopState();
Player player = new Player(stop);
player.Status();
State.State play = new PlayState();
player.TransitionTo(play );
player.Status();
