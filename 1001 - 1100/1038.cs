using System; 

class URI {

    static void Main(string[] args) { 

        string[] linha = Console.ReadLine().Split(' ');
        
        int cod = Int32.Parse(linha[0]);
        int qtd = Int32.Parse(linha[1]);
        
        double preco = 0.0;
        
        if(cod == 1){
            preco = 4 * qtd;    
        } if(cod == 2){
            preco = 4.50 * qtd;  
        } if(cod == 3){
            preco = 5 * qtd;  
        } if(cod == 4){
            preco = 2 * qtd;  
        } if(cod == 5){
            preco = 1.50 * qtd;  
        }
    
        Console.WriteLine("Total: R$ {0:0.00}", preco);
    
    }

}
