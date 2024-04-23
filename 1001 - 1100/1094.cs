using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        string[] input;
        int qtd, coelho = 0, rato = 0, sapo = 0, total = 0;
        char tipo;
        
        for(int i = 0; i < N; i++){
            input = Console.ReadLine().Split(' ');
            qtd = int.Parse(input[0]);
            tipo = char.Parse(input[1]);
            total += qtd;
            if(tipo == 'R'){
                rato += qtd;
            } else if(tipo == 'S'){
                sapo += qtd;
            } else if(tipo == 'C'){
                coelho += qtd;
            }
        }
        
        Console.WriteLine($"Total: {total} cobaias");
        Console.WriteLine($"Total de coelhos: {coelho}");
        Console.WriteLine($"Total de ratos: {rato}");
        Console.WriteLine($"Total de sapos: {sapo}");
        Console.WriteLine("Percentual de coelhos: {0:0.00} %", ((100.00/total)*coelho));
        Console.WriteLine("Percentual de ratos: {0:0.00} %",  ((100.00/total)*rato));
        Console.WriteLine("Percentual de sapos: {0:0.00} %",  ((100.00/total)*sapo));

    }

}
