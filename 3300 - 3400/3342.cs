using System; 

class URI {

    static void Main(string[] args) { 

        int num = Convert.ToInt32(Console.ReadLine());
        
        int casas = num*num;
        
        int branco, preta;
        
        if(casas % 2 == 0){
            branco = casas /2;
            preta = casas /2;
        } else{
            branco = ((casas-1)/2)+1;
            preta = (casas-1)/2;
        }
        
        Console.WriteLine("{0} casas brancas e {1} casas pretas", branco, preta);
       
    }

}
