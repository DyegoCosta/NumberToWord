using System.Collections.Generic;
using NumberToWord.Expressions;

namespace NumberToWord
{
    public static class Parser
    {
        public static string ToWord(this int number)
        {
            var context = new Context(number);

            // Build the 'parse tree'
            ICollection<Expression> expressionTree = new HashSet<Expression>
                                        {
                                            new HundredExpression(),
                                            new ThousandExpression(),
                                            new MillionExpression(),
                                            new BillionExpression()
                                        };
            
            // Interpret
            foreach (Expression expression in expressionTree)            
                expression.Interpret(context);

            // Return the context output
            return context.Output;
        }
    }
}
