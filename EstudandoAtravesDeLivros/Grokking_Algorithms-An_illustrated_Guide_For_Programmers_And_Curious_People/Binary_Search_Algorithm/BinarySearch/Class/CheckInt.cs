using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Class
{
    public class CheckInt
    {
        public static int RequiestInt(string mensage)
        {
            int value;
            bool valid = false;

            do
            {
                System.Console.Write(mensage);
                valid = int.TryParse(Console.ReadLine(), out value);

                if (!valid || value <= 1)
                {
                    System.Console.Write("\nInvalid Input.\nPlease, enter a positive integer.\n\n");
                    valid = false;
                }
            } while (!valid);
            return value;
        }
        public static List<int> CreateList(string mensage, int total)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < total; i++)
            {
                int value = RequiestInt($"{mensage}\n({i + 1}/{total}): ");
                list.Add(value);
            }
            return list;
        }
        public static void BinarySearch(int total)
        {
            int attempts = 1;
            int choice = 0;
            int amount = total;
            bool chosenNumber = false;

            List<int> list = new List<int>(CheckInt.CreateList("Please enter the numbers: ", amount));
            Console.WriteLine("Choose a number, but don't tell me!\n");
            Thread.Sleep(2000);
            list.Sort();

            do
            {
                int middleOfTheList = list.Count / 2;
                int middleNumber = list[middleOfTheList];

                System.Console.Write($"\nHmm... I think you choose the {middleNumber}!" +
                "\nThe choosed number is:" +
                "\n(1) Greater" +
                "\n(2) Lower" +
                "\n(3) Exactly value" +
                "\nAnswer: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        list.RemoveRange(0, middleOfTheList + 1);
                        break;
                    case 2:
                        list.RemoveRange(middleOfTheList, list.Count - middleOfTheList);
                        break;
                    case 3:
                        chosenNumber = true;
                        if (attempts == 1)
                        {
                            Console.WriteLine($"Wow, i got it on the first attempt!");
                        }
                        else
                        {
                            System.Console.WriteLine($"Phew, i finally found it after {attempts} attempts!");
                        }
                        break;
                    default:
                        System.Console.WriteLine("invalid option. Please type a number btween 1, 2 or 3.");
                        break;
                }
                attempts++;
            } while (!chosenNumber);
        }
    }
}
