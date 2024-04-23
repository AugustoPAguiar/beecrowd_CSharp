using System; 

class URI {

    static void Main(string[] args) { 

        int A, B, C, D, diferenca;
        
        A = Convert.ToInt32(Console.ReadLine());
        B = Convert.ToInt32(Console.ReadLine());
        C = Convert.ToInt32(Console.ReadLine());
        D = Convert.ToInt32(Console.ReadLine());
        
        diferenca = (A * B - C * D);
        
        Console.WriteLine("DIFERENCA = {0}", diferenca);

    }

}
