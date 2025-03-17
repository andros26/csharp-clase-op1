using System.Data;
using System.Dynamic;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            DateOnly dataConverted = new DateOnly();
            string nameInput;
            string birthdayInput;
            Console.WriteLine("Calculador de años");
            Console.Write("Escribe tu nombre: ");
            nameInput = Console.ReadLine();
            Console.Write("Ingresa tu fecha de nacimiento en formato dd/mm/yy: ");
            birthdayInput = Console.ReadLine();
            bool isDataValid = DateOnly.TryParse(birthdayInput, out dataConverted);
            if (isDataValid == false) Console.WriteLine($"La fecha {birthdayInput} es invalida");
            var person = new Person
            {
                Name = nameInput,
                Birthday = dataConverted,
                Age = DateTime.Now.Year - dataConverted.Year
            };

            Console.WriteLine($"Tú nombre: {person.Name}");
            Console.WriteLine($"Tú fecha de nacimiento:  {person.Birthday}");
            Console.WriteLine($"Tú edad es:  {person.Age} años");

            Console.ReadLine();

        }
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public DateOnly Birthday { get; set; }

}