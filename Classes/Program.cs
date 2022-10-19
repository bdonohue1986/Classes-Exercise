namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can we get some info about you first?");
            Console.WriteLine("Whats your Name?");
            var Customer = new Car();
            Customer.Name = Console.ReadLine();
            Console.WriteLine("And what Model is it");
            Customer.Make = Console.ReadLine();
            Console.WriteLine("And the Year?");
            Customer.Year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What Model");
            Customer.Model = Console.ReadLine();

            Customer.CustomerGreeting();
            Customer.CusotmerCheckOut();
        }
    }
}
