namespace Interpreter
{
    public abstract class BooleanExp
    {
        public abstract bool Evaluate(Context context);
        public abstract BooleanExp Replace(string name, BooleanExp booleanExp);
        public abstract BooleanExp Copy();
    }
}