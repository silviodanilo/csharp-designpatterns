
namespace Memento
{
    public class Caretaker
    {
        public Originator? Originator;
        private Stack<Memento.Originator.Memento> _history = new Stack<Memento.Originator.Memento>();

        public Caretaker(Originator originator)
        {
            this.Originator = originator;
        }

        public void Move()
        {
            _history.Push(Originator!.SaveMemento());
            Originator.Move();
        }
        public void Undo()
        {
            if (_history.Count > 0)
                Originator!.RestoreMemento(_history.Pop());
        }
    }
}