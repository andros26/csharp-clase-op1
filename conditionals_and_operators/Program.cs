namespace conditionals_and_operators
{
    class Program
    {
        static void Main()
        {
            /*Conditionals*/
            /*
            Console.Write("Ingrese un número: ");
            int num =int.Parse(Console.ReadLine());
            if (num > 0)Console.WriteLine("Positivo");
            else if(num < 0)Console.WriteLine("Negativo");
            else Console.WriteLine(" Es cero");
            */

            /*Operators*/
            Console.Write("Ingrese elprimer numero: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Suma: {a+b}, Resta: {a-b}, Multiplicación: {a*b}," +  (b != 0 ? $"División: {a / b}" : "División indeterminada"));

        }
    }
}