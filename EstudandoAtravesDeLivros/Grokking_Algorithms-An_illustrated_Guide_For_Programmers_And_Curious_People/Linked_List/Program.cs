using Class;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add("Adit");
            list.Add("Rafael");
            list.Add("William Naja");

            Console.WriteLine("List:\n");
            list.Show();
        }
    }
}