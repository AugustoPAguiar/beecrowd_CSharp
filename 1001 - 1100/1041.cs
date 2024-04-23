using System; 

class URI {

    static void Main(string[] args) { 

        string[] linha = Console.ReadLine().Split(' ');
        
        double X = double.Parse(linha[0]);
        double Y = double.Parse(linha[1]);
        
        if(X == 0 && Y == 0){
            Console.WriteLine("Origem");
        } else if(X > 0 && Y > 0){
            Console.WriteLine("Q1");
        } else if(X < 0 && Y > 0){
            Console.WriteLine("Q2");
        } else if(X < 0 && Y < 0){
            Console.WriteLine("Q3");
        } else if(X > 0 && Y < 0){
            Console.WriteLine("Q4");  
        } else if(X == 0){
            Console.WriteLine("Eixo Y");
        } else if(Y == 0){
            Console.WriteLine("Eixo X");
        }

    }

}
