using System; 

class URI {

    static void Main(string[] args) { 

        int tempo = Convert.ToInt32(Console.ReadLine());
        int velocidade = Convert.ToInt32(Console.ReadLine());

        double distancia = velocidade * tempo;

        double litrosNecessarios = distancia / 12;

        Console.WriteLine("{0:0.000}", litrosNecessarios);
    }

}
