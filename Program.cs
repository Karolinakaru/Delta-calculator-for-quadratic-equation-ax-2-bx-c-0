internal class Program
{
    private static void Main(string[] args)
    {
        // Program liczy deltę dla równania kwadratowego ax^2 + bx + c = 0
        // po otrzymaniu od użytkownia a,b,c wyrażonych w wartościach liczbowych
        //The program calculates the delta for the quadratic equation ax^2 + bx + c = 0
        //after receiving a, b, c expressed in numerical values from the user
        double a, b, c, wynik;
        Console.WriteLine("Let's calculate quadratic equation: ax^2 + bx + c = 0");
        Console.WriteLine("Enter the value of \"a\"and press Enter");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of \"b\"and press Enter");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of \"c\"and press Enter");
        c = double.Parse(Console.ReadLine());
        wynik = (Math.Pow(b, 2) - (4 * a * c ));
        Console.WriteLine("The result is: " + wynik);
        Console.ReadKey();









   }
}
