namespace Interpreter
{
    public class NotExp : BooleanExp
    {
        private BooleanExp _operand;
        public NotExp(BooleanExp booleanExp)
        {
            this._operand = booleanExp;
        }
        public override bool Evaluate(Context context)
        {
            return !_operand.Evaluate(context);
        }
        public override BooleanExp Replace(string name, BooleanExp booleanExp)
        {
            return new NotExp(_operand.Replace(name, booleanExp));
        }
        public override BooleanExp Copy()
        {
            return new NotExp(_operand.Copy());
        }
    }
}