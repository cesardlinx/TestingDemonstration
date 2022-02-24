namespace TestingDemonstration.Implementation
{
    public class PalindromeChecker
    {
        public bool Check(string word)
        {
            if (string.IsNullOrEmpty(word)) return false;

            var areAllLetters = word.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c));
            if (!areAllLetters) throw new ArgumentException();

            var reversed = new string(word.Reverse().ToArray());
            return reversed.Equals(word);
        }
    }
}
