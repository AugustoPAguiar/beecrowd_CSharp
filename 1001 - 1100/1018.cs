using System; 

class URI {

    static void Main(string[] args) { 

        int notas;
        int valor = Convert.ToInt32(Console.ReadLine());
    
        Console.WriteLine(valor);
    
        notas = valor / 100;
        Console.WriteLine($"{notas} nota(s) de R$ 100,00");
        valor = valor - (notas * 100);
        
        notas = valor / 50;
        Console.WriteLine($"{notas} nota(s) de R$ 50,00");
        valor = valor - (notas * 50);
        
        notas = valor / 20;
        Console.WriteLine($"{notas} nota(s) de R$ 20,00");
        valor = valor - (notas * 20);
        
        notas = valor / 10;
        Console.WriteLine($"{notas} nota(s) de R$ 10,00");
        valor = valor - (notas * 10);
        
        notas = valor / 5;
        Console.WriteLine($"{notas} nota(s) de R$ 5,00");
        valor = valor - (notas * 5);
        
        notas = valor / 2;
        Console.WriteLine($"{notas} nota(s) de R$ 2,00");
        valor = valor - (notas * 2);
        
        notas = valor / 1;
        Console.WriteLine($"{notas} nota(s) de R$ 1,00");
        valor = valor - (notas * 1);
        
    }

}
