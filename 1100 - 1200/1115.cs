using System; 

class URI {

    static void Main(string[] args) { 

        string[] cordenada;
        bool rodar = true;
        
        while(rodar == true){
            
            cordenada = Console.ReadLine().Split(' ');
              
            int X = int.Parse(cordenada[0]);
            int Y = int.Parse(cordenada[1]);
        
            if(X == 0 || Y == 0){
                rodar = false;
            } else if(X > 0 && Y > 0){
                Console.WriteLine("primeiro");
            } else if(X < 0 && Y > 0){
                Console.WriteLine("segundo");
            } else if(X < 0 && Y < 0){
                Console.WriteLine("terceiro");
            } else if(X > 0 && Y < 0){
                Console.WriteLine("quarto");
            }
            
        }
       
    }

}
