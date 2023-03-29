using System;


namespace _01_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Labas, Viktorija");
            int amzius = 36;
            Console.WriteLine($"Įvestas amžius: {amzius}");
            Console.WriteLine();
            int skaicius = 25;
            //užduotis su skaičiu 25 be tarpų
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.WriteLine();
            //užduotis su skaičiu 25 su tarpais
            Console.Write(skaicius + " ");
            Console.Write(skaicius + " ");
            Console.Write(skaicius + " ");
            Console.Write(skaicius + " ");
            Console.Write(skaicius + " ");
            Console.WriteLine();
        }
    }
}
