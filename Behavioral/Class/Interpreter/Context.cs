namespace Interpreter
{
    public class Context
    {
        private Dictionary<string, bool> _boolVariables = new();

        public Context()
        {
            _boolVariables.Add("true", true);
            _boolVariables.Add("false", false);
        }
        
        public bool Lookup(string name)
        {
            return _boolVariables[name];
        }
        public void Assign(VariableExp variableExp, bool b)
        {
            _boolVariables.Add(variableExp.Name, b);
        }
    }
}