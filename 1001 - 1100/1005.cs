using System; 

class URI {

    static void Main(string[] args) { 

        double A, B, media;
        
        A = Convert.ToDouble(Console.ReadLine());
        B = Convert.ToDouble(Console.ReadLine());
        
        media = ((A*3.5) + (B*7.5)) / 11.0;
        
        Console.WriteLine("MEDIA = {0:0.00000}", media);
        
    }

}
