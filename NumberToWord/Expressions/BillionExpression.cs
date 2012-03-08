namespace NumberToWord.Expressions
{
    public class BillionExpression : Expression
    {
        public override string NumberWord() { return "billion"; }

        public override int Multiplier() { return 1000000000; }
    }
}
