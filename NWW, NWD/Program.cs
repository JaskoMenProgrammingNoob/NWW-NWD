using System.Security.Cryptography;

class Matematyka
{
    public int NWD(int a, int b)
    {

        if (b == 0)
        {
            return a;
        } 
        
            return NWD(b, a % b);
        

    }
     public int NWW(int a, int b)
    {
        if (a == 0 || b == 0)
        {
            return 0;
        }
        return ((a * b) / NWD(a, b));


    } 
}
class Program
{

    


    static void Main (string[] args)
    {
        Console.WriteLine("Podaj pierwszą liczbę: ");
        int pierwsza = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj drugą liczbę: ");
        int druga = int.Parse(Console.ReadLine());
        Matematyka matematyka = new Matematyka();
        matematyka.NWD(pierwsza,druga);
        matematyka.NWW(pierwsza,druga);
        Console.WriteLine($"Największy wspólny dzielnik: {matematyka.NWD(pierwsza,druga)}");
        Console.WriteLine($"Najmniejsza wspólna wielokrotność: {matematyka.NWW(pierwsza, druga)}");
    }
}