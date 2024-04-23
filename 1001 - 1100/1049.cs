using System; 

class URI {

    static void Main(string[] args) { 

        string classe, tipo, comida;
        
        classe = Console.ReadLine();
        tipo = Console.ReadLine();
        comida = Console.ReadLine();
        
        if(classe == "vertebrado"){
            if(tipo == "ave"){
                if(comida == "carnivoro"){
                    Console.WriteLine("aguia");
                } else if(comida == "onivoro"){
                    Console.WriteLine("pomba");
                }
            } else if(tipo == "mamifero"){
                if(comida == "onivoro"){
                    Console.WriteLine("homem");
                } else if(comida == "herbivoro"){
                    Console.WriteLine("vaca");
                }
            } 
            
        } else if(classe == "invertebrado"){
            if(tipo == "inseto"){
                if(comida == "hematofago"){
                    Console.WriteLine("pulga");
                } else if(comida == "herbivoro"){
                    Console.WriteLine("lagarta");
                }
            } else if(tipo == "anelideo"){
                if(comida == "hematofago"){
                    Console.WriteLine("sanguessuga");
                } else if(comida == "onivoro"){
                    Console.WriteLine("minhoca");
                }
            } 
        }

    }

}
