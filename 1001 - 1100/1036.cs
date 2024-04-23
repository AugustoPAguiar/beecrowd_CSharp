using System; 

class URI {

    static void Main(string[] args) { 
        
        // Leitura dos coeficientes A, B e C
        string[] linha = Console.ReadLine().Split(' ');
        double A = Double.Parse(linha[0]);
        double B = Double.Parse(linha[1]);
        double C = Double.Parse(linha[2]);

        // Cálculo do delta
        double delta = B * B - 4 * A * C;
        
        if(delta <=0 || A == 0){
            
            Console.WriteLine("Impossivel calcular");
            
        } else{
            
            //Calculo dos X1 e X2
            double X1 = (-B + Math.Sqrt(delta)) / (2 * A);
            double X2 = (-B - Math.Sqrt(delta)) / (2 * A);
            
            Console.WriteLine("R1 = {0:0.00000}", X1);
            Console.WriteLine("R2 = {0:0.00000}", X2);
            
        }
      
    }

}
