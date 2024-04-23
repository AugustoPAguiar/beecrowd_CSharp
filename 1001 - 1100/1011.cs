using System; 

class URI {

    static void Main(string[] args) { 

        double raio, volume;
        
        raio = Convert.ToDouble(Console.ReadLine());
        
        volume = (4.0/3.0) * 3.14159 * (raio * raio * raio);
        
        Console.WriteLine("VOLUME = {0:F3}", volume);
        
        

    }

}
