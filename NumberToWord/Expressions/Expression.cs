namespace NumberToWord.Expressions
{
    public abstract class Expression
    {        
        private string word;
        
        private string fullNumber;
        private string partialNumber;        
        
        private string firstNumberString;
        private string secondNumberString;
        private string thirdNumberString;

        public void Interpret(Context context)
        {
            ResolveCurrentNumbers(context.Input);

            for (int part = 1; part <= partialNumber.Length; part++)
                WritePartialNumberParts(part);

            context.AddWord(word.Trim());

            var currentNumber = fullNumber.Remove(fullNumber.Length - 3, 3);
            context.Input = string.IsNullOrEmpty(currentNumber) ? 0 : int.Parse(currentNumber);
        }

        private string UnitWord(int number)
        {
            switch (number)
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return string.Empty;
            }
        }

        private string TenToNineteen(int number)
        {
            switch (number)
            {
                case 10:
                    return "ten";
                case 11:
                    return "eleven";
                case 12:
                    return "twelve";
                case 13:
                    return "trirteen";
                case 14:
                    return "fourteen";
                case 15:
                    return "fifteen";
                case 16:
                    return "sixteen";
                case 17:
                    return "seventeen";
                case 18:
                    return "eighteen";
                case 19:
                    return "nineteen";
                default:
                    return string.Empty;
            }
        }

        private string DozenWord(int number)
        {
            switch (number)
            {
                case 2:
                    return "twenty";
                case 3:
                    return "thirty";
                case 4:
                    return "fourty";
                case 5:
                    return "fifty";
                case 6:
                    return "sixty";
                case 7:
                    return "seventy";
                case 8:
                    return "eightty";
                case 9:
                    return "ninety";
                default:
                    return string.Empty;
            }
        }

        private string HundredWord()
        {
            return "hundred";
        }

        private void ResolveCurrentNumbers(int completeNumber)
        {
            fullNumber = completeNumber.ToString("D3");

            partialNumber = fullNumber.Substring(fullNumber.Length - 3, 3);

            firstNumberString = partialNumber.Substring(0, 1);
            secondNumberString = partialNumber.Substring(1, 1);
            thirdNumberString = partialNumber.Substring(2, 1);
        }

        private void WritePartialNumberParts(int part)
        {
            switch (part)
            {
                case 1:
                    WriteFirstPartialNumberPart();
                    break;
                case 2:
                    WriteSecondPartialNumberPart();
                    break;
                case 3:
                    WriteThridPartialNumberPart();
                    break;
            }
        }

        private void WriteFirstPartialNumberPart()
        {
            int firstNumber;

            if (int.TryParse(firstNumberString, out firstNumber))
                word = string.Format("{0} {1}", UnitWord(firstNumber), (firstNumber > 0 ? HundredWord() : string.Empty)).TrimEnd();
        }

        private void WriteSecondPartialNumberPart()
        {
            int firstNumber = int.Parse(firstNumberString);

            int secondNumber;

            if (int.TryParse(secondNumberString, out secondNumber))
                if (secondNumber == 0 && firstNumber > 0)
                    word = string.Format("{0} {1}", word, "and");
                else if (secondNumber > 1)
                    word = string.Format("{0} {1}", word, DozenWord(secondNumber)).TrimEnd();
                else
                    word = string.Format("{0} {1}", word, TenToNineteen(int.Parse(secondNumberString + thirdNumberString))).TrimEnd();
        }

        private void WriteThridPartialNumberPart()
        {
            int secondNumber = int.Parse(secondNumberString);
            
            int thirdNumber;

            if (int.TryParse(thirdNumberString, out thirdNumber) && secondNumber != 1)
                word = string.Format("{0}{1}{2}", word, secondNumber > 1 && thirdNumber > 0 ? "-" : " ", UnitWord(thirdNumber)).TrimEnd();

            word += " " + (int.Parse(partialNumber) > 0 ? NumberWord() : string.Empty);
        }

        public abstract string NumberWord();

        public abstract int Multiplier();
    }
}