
namespace Memento
{
    public class Originator
    {
        private int _cordX;
        private int _cordY;
        private string? _collor;

        public Originator(int cordX, int cordY, string collor)
        {
            this._cordX = cordX;
            this._cordY = cordY;
            this._collor = collor;
        }

        public Memento SaveMemento()
        {
            return new Memento(this._cordX, this._cordY, this._collor);
        }

        public void Move()
        {
            this._cordX++;
            this._cordY++;
        }
        public void RestoreMemento(Memento memento)
        {
            this._cordX = memento.CordX;
            this._cordY = memento.CordY;
            this._collor = memento.Collor;
        }

        public override string ToString()
        {
            return $"{this._cordX}, {this._cordY}, {this._collor}";
        }
        //Nested class
        public class Memento
        {
            internal int CordX{ get; }
            internal int CordY{ get; }
            internal string? Collor{ get; }

            public Memento( int cordX, int cordY, string collor)
            {
                this.CordX = cordX;
                this.CordY = cordY;
                this.Collor = collor;
            }

        }
    }
}