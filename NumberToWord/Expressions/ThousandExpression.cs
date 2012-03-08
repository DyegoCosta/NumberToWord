namespace NumberToWord.Expressions
{
    public class ThousandExpression : Expression
    {
        public override string NumberWord() { return "thousand"; }

        public override int Multiplier() { return 1000; }
    }
}
