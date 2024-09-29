namespace Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Age;
            int intAge;
            Console.WriteLine("Enter your age ...");
            Age = Console.ReadLine();
            intAge = int.Parse(Age);
            if (intAge>18)
            {
                Console.WriteLine("Your age is passed");
            }
            else
            {
                Console.WriteLine("Your age is not passed");
            }
        }
    }
}
