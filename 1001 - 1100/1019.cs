using System; 

class URI {

    static void Main(string[] args) { 

        int segundo, hora, minuto;
        
        segundo = Convert.ToInt32(Console.ReadLine());
        
        hora = segundo / 3600;
        segundo = segundo - hora * 3600;
        
        minuto = segundo / 60;
        segundo = segundo - minuto * 60;
        
        Console.WriteLine($"{hora}:{minuto}:{segundo}");

    }

}
