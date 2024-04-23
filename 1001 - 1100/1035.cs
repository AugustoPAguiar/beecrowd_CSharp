using System; 

class URI {

    static void Main(string[] args) { 

        string[] linha = Console.ReadLine().Split(' ');
        
        int A = Int32.Parse(linha[0]);
        int B = Int32.Parse(linha[1]);
        int C = Int32.Parse(linha[2]);
        int D = Int32.Parse(linha[3]);
        
        if(B > C && D > A && (C+D) > (A+B) && C > 0 && D > 0 && (A%2)==0){
            Console.WriteLine("Valores aceitos");
        } else {
            Console.WriteLine("Valores nao aceitos");
        }

    }

}
