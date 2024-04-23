using System; 

class URI {

    static void Main(string[] args) { 
double valor, notas;
        int moedas;

        valor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("NOTAS:");

        notas = Math.Floor(valor / 100);
        valor %= 100;
        Console.WriteLine($"{notas} nota(s) de R$ 100.00");

        notas = Math.Floor(valor / 50);
        valor %= 50;
        Console.WriteLine($"{notas} nota(s) de R$ 50.00");

        notas = Math.Floor(valor / 20);
        valor %= 20;
        Console.WriteLine($"{notas} nota(s) de R$ 20.00");

        notas = Math.Floor(valor / 10);
        valor %= 10;
        Console.WriteLine($"{notas} nota(s) de R$ 10.00");

        notas = Math.Floor(valor / 5);
        valor %= 5;
        Console.WriteLine($"{notas} nota(s) de R$ 5.00");

        notas = Math.Floor(valor / 2);
        valor %= 2;
        Console.WriteLine($"{notas} nota(s) de R$ 2.00");

        Console.WriteLine("MOEDAS:");

        moedas = (int)valor;
        valor -= moedas;
        Console.WriteLine($"{moedas} moeda(s) de R$ 1.00");

        moedas = (int)(valor / 0.5);
        valor %= 0.5;
        Console.WriteLine($"{moedas} moeda(s) de R$ 0.50");

        moedas = (int)(valor / 0.25);
        valor %= 0.25;
        Console.WriteLine($"{moedas} moeda(s) de R$ 0.25");

        moedas = (int)(valor / 0.1);
        valor %= 0.1;
        Console.WriteLine($"{moedas} moeda(s) de R$ 0.10");

        moedas = (int)(valor / 0.05);
        valor %= 0.05;
        Console.WriteLine($"{moedas} moeda(s) de R$ 0.05");

        moedas = (int)Math.Round(valor / 0.01);
        Console.WriteLine($"{moedas} moeda(s) de R$ 0.01");
        
    }
}
