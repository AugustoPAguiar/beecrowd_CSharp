using System; 

class URI {

    static void Main(string[] args) { 

       string[] linha = Console.ReadLine().Split(' ');
       
        int maior;
        int A = Int32.Parse(linha[0]);
        int B = Int32.Parse(linha[1]);
        int C = Int32.Parse(linha[2]);
        
        maior = ((A+B+Math.Abs(A-B)) / 2);
        
        maior = (( maior + C + Math.Abs(maior-C) ) / 2);
    
        Console.WriteLine("{0} eh o maior", maior);
        
    }

}
