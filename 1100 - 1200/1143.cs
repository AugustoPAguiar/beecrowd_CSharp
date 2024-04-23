using System; 

class URI {

    static void Main(string[] args) { 

        int quantidade = int.Parse(Console.ReadLine());
        
        for(int i = 1; i <= quantidade; i++){
            Console.WriteLine("{0} {1} {2}", (i), (i*i), (i*i*i) );
        }

    }

}
