using System; 

class URI {

    static void Main(string[] args) { 
      
        string[] linha1 = Console.ReadLine().Split(' ');
        int cod1 = int.Parse(linha1[0]);
        int qtd1 = int.Parse(linha1[1]);
        double preco1 = double.Parse(linha1[2]);
        
        string[] linha2 = Console.ReadLine().Split(' ');
        int cod2 = int.Parse(linha2[0]);
        int qtd2 = int.Parse(linha2[1]);
        double preco2 = double.Parse(linha2[2]);
        
        double total = (qtd1 * preco1) + (qtd2 * preco2);
        
        Console.WriteLine("VALOR A PAGAR: R$ {0:0.00}", total);

    }

}
