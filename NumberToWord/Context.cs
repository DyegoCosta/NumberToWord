namespace NumberToWord
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class Context
    {
        public Context(int input)
        {
            Input = input;
        }        

        public int Input { get; set; }

        public string Output { get; private set; }

        public void AddWord(string word)
        {
            Output = string.Format("{0} {1}", word, Output).Trim();            
        }
    }
}
