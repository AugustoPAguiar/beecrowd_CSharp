using System; 

class URI {

    static void Main(string[] args) { 

        int X = Convert.ToInt32(Console.ReadLine());
        double Y = Convert.ToDouble(Console.ReadLine());
        
        double km = X / Y;
        
        Console.WriteLine("{0:0.000} km/l", km);
    }

}
