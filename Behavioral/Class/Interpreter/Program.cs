/*
Grammar - GOF
    BooleanExp = VariableExp | Constant | OrExp | AndExp | NotExp | '(' BooleanExp ')'
    AndExp = BoolenaExp 'and' BooleanExp
    OrExp = BooleanExp 'or' BooleanExp
    NotExp = 'not' BooleanExp
    Constant = 'true' | 'false'
    VariableExp = 'A' | 'B' | ..... | 'X' | 'Y' | 'Z'
*/

using Interpreter;

BooleanExp expression;
Context context = new Context();

VariableExp x = new("X");
VariableExp y = new("Y");

NotExp notExp = new(x);
AndExp andExp = new(y, notExp);
Constant _true = new(true);
AndExp andExp1 = new(_true, x);

expression = new OrExp(andExp1, andExp);

context.Assign(x, false);
context.Assign(y, true);

bool result = expression.Evaluate(context);

System.Console.WriteLine("Evaluating (true and x) or ( ( y and ( not x) ) )");
System.Console.WriteLine(result.ToString());

VariableExp z = new("Z");
NotExp not_z = new NotExp(z);
BooleanExp replacement = expression.Replace("Y", new Constant(false));
context.Assign(z, true);
result = replacement.Evaluate(context);

System.Console.WriteLine("Evaluating (true and x) or ( ( not z and ( not x) ) )");
System.Console.WriteLine(result.ToString());


