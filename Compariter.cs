namespace Generator
{
    internal class Comperator
    {
        private readonly int _guid;

        public Comperator(int guid)
        {
            _guid = guid;
        }

        public static string Get() => "Buzz";

        public string GetComperator() => "Fizz";

        //public const char[] NotTheAlphabet = new char[]
        //{

        //}
    }
}
