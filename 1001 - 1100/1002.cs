using System; 

class URI {

    static void Main(string[] args) { 

        double area, raio, pi=3.14159;
        
        raio=Convert.ToDouble(Console.ReadLine());
        
        area=pi*(raio*raio);
        
        Console.WriteLine($"A={string.Format("{0:0.0000}",area)}");

    }
 
}
