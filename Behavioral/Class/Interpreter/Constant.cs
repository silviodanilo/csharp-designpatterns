namespace Interpreter
{
    public class Constant : BooleanExp
    {
        public string Name { get; set; }

        public Constant(bool value)
        {
            if (value)
                this.Name = "true";
            else
                this.Name = "false";
        }
        public override bool Evaluate(Context context)
        {
            return context.Lookup(Name);
        }
        //keep the value
        public override BooleanExp Replace(string name, BooleanExp booleanExp)
        {
            return booleanExp.Copy();
        }
        public override BooleanExp Copy()
        {
            if (Name == "true")
                return new Constant(true);
            else
                return new Constant(false);
        }
    }

}