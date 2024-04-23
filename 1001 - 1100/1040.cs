using System; 

class URI {

    static void Main(string[] args) { 

        string[] linha = Console.ReadLine().Split(' ');
        
        double a = Double.Parse(linha[0]);
        double b = Double.Parse(linha[1]);
        double c = Double.Parse(linha[2]);
        double d = Double.Parse(linha[3]);

        double media = ((a*2) + (b*3) + (c*4) + (d*1)) / 10;
        media = Math.Floor(media*100) / 100;
        Console.WriteLine("Media: {0:0.0}",media);
        
        if(media>=7.0){
            Console.WriteLine("Aluno aprovado.");
        } else if(media<5.0){
            Console.WriteLine("Aluno reprovado.");
        } else{
            Console.WriteLine("Aluno em exame.");
            
            double exame = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota do exame: {0:0.0}",exame);
            
            exame = (exame + media) / 2;
            
            if(exame >= 5.0){
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine("Media final: {0:0.0}",exame);
            } else{
                Console.WriteLine("Aluno reprovado.");    
            }
            
            
        }

        
        
    }

}
