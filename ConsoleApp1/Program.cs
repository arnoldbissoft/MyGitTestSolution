using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                PersonId = 1,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1978, 1, 1)
            };

            Console.WriteLine("Hello World!");
        }
    }
}
