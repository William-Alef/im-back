namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Type a word: ");
            string word = Console.ReadLine();

            string reverse = new string(word.Reverse().ToArray());
            System.Console.WriteLine(reverse == word);
        }
    }
}