using System; 

class URI {

    static void Main(string[] args) { 

        string nome = Console.ReadLine();
        
        double salario = Convert.ToDouble(Console.ReadLine());
        
        double comissao = Convert.ToDouble(Console.ReadLine());
        
        double totalRecebido = salario + (comissao * 0.15);
        
        Console.WriteLine("TOTAL = R$ {0:0.00}", totalRecebido);

    }

}
