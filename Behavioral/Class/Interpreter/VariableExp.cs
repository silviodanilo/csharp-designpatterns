namespace Interpreter
{
    public class VariableExp : BooleanExp
    {
        public string Name{ get; set; }
        public VariableExp(string name)
        {
            this.Name = name;
        }
        public override bool Evaluate(Context context)
        {
            return context.Lookup(Name);
        }
        public override BooleanExp Replace(string name, BooleanExp booleanExp)
        {
            if (Name == name)
                return booleanExp.Copy();
            else
                return new VariableExp(Name);
        }
        public override BooleanExp Copy()
        {
            return new VariableExp(Name);
        }
    }

}