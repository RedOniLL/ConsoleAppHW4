namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to call the method:");
            int choice = int.Parse(Console.ReadLine());

            
            switch (choice)
            {
                case 1:
                    Class1.Task1();
                    break;
                case 2:
                    Class1.Task2();
                    break;
                case 3:
                    try
                    {
                        Passport myPassport = new Passport("23094203492", "Name Name", new DateTime(2004, 1, 20));

                        Console.WriteLine("Passport details:");
                        Console.WriteLine($"Passport number: {myPassport.PassportNumber}");
                        Console.WriteLine($"Full name: {myPassport.FullName}");
                        Console.WriteLine($"Issue date: {myPassport.IssueDate.ToShortDateString()}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
