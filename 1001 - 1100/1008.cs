using System; 

class URI {

    static void Main(string[] args) { 

        int funcionario, horas;
        double valor, salario;

        funcionario = Convert.ToInt32(Console.ReadLine());
        horas = Convert.ToInt32(Console.ReadLine());
        valor = Convert.ToDouble(Console.ReadLine());
        
        salario = horas * valor;
        
        Console.WriteLine("NUMBER = {0}", funcionario);
        Console.WriteLine("SALARY = U$ {0:0.00}", salario);

    }

}
