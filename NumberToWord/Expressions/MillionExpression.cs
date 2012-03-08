namespace NumberToWord.Expressions
{
    public class MillionExpression : Expression
    {
        public override string NumberWord() { return "million"; }

        public override int Multiplier() { return 1000000; }
    }
}
