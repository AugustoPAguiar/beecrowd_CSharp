using System; 

class URI {

    static void Main(string[] args) { 

        int anos, meses, dias;
        
        dias = Convert.ToInt32(Console.ReadLine());
        
        anos = dias / 365;
        dias = dias - anos * 365;
        
        meses = dias / 30;
        dias = dias - meses * 30;
        
        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");

    }

}
