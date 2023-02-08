namespace Interpreter
{
    public class OrExp : BooleanExp
    {
        private BooleanExp _operand1;
        private BooleanExp _operand2;
        public OrExp(BooleanExp booleanExp1, BooleanExp booleanExp2)
        {
            this._operand1 = booleanExp1;
            this._operand2 = booleanExp2;
        }

        public override bool Evaluate(Context context)
        {
            return _operand1.Evaluate(context) || _operand2.Evaluate(context);
        }
        public override BooleanExp Replace(string name, BooleanExp booleanExp)
        {
            return new OrExp(_operand1.Replace(name, booleanExp), _operand2.Replace(name, booleanExp));
        }
        public override BooleanExp Copy()
        {
            return new OrExp(_operand1.Copy(), _operand2.Copy());
        }
    }
}