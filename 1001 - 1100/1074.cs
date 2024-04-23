using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine()), num;
        
        for(int i = 0; i < N; i++){
            num = int.Parse(Console.ReadLine());
            
            if(num > 0){
                if(num % 2 == 0){
                    Console.WriteLine("EVEN POSITIVE");
                } else{
                    Console.WriteLine("ODD POSITIVE");
                }
            } else if(num < 0){
                if(num % 2 == 0){
                    Console.WriteLine("EVEN NEGATIVE");
                } else{
                    Console.WriteLine("ODD NEGATIVE");
                }
            } else {
                Console.WriteLine("NULL");
            }
        }

    }

}
