using System; 

class URI {

    static void Main(string[] args) { 
        
        double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;
        
        string[] linha = Console.ReadLine().Split(' ');
        
        A = double.Parse(linha[0]);
        B = double.Parse(linha[1]);
        C = double.Parse(linha[2]);

        triangulo = (A * C)/2.0;
        circulo = 3.14159 * (C * C);
        trapezio = ((A + B) * C) / 2.0;
        quadrado = B * B;
        retangulo = A * B;
        
        Console.WriteLine("TRIANGULO: {0:F3}", triangulo);
        Console.WriteLine("CIRCULO: {0:F3}", circulo);
        Console.WriteLine("TRAPEZIO: {0:F3}", trapezio);
        Console.WriteLine("QUADRADO: {0:F3}", quadrado);
        Console.WriteLine("RETANGULO: {0:F3}", retangulo);

    }

}
