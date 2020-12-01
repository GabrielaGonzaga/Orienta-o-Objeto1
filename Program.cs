using System;

namespace Orientação_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá jogador!");

            Personagem Obj1= new Personagem ();

            Obj1.nome="Gabriela";
            Obj1.idade="18";
            Obj1.cordaroupa="Laranja";
            Obj1.comer();
            Obj1.comers();
            Obj1.ajudar();
            
            Personagem Obj2= new Personagem ();
            Obj2.nome="Vinicius";
            Obj2.idade="17";
            Obj2.cordaroupa="Azul";
            Obj2.comer();
            Obj2.comers();
            Obj2.ajudar();

            Console.WriteLine("Escolha um Personagem e digite seu nome =");
            Console.WriteLine($"Personagem 1 = {Obj1.nome}");
            Console.WriteLine($"Personagem 2 = {Obj2.nome}");
            string nome = Console.ReadLine();

            if(nome == "Vinicius"){
                Console.WriteLine($"olá "+nome+" sua idade é de "+Obj2.idade+" anos e a cor da sua roupa é "+Obj2.cordaroupa+"");
            }
            else if (nome == "Gabriela"){
                Console.WriteLine($"olá "+nome+" sua idade é de "+Obj1.idade+" anos e a cor da sua roupa é "+Obj1.cordaroupa+"");
            }
            else{
                Console.WriteLine("Nome inválido!");
            }

            Console.WriteLine("Vamos lá, irei fazer algumas perguntar para você");
            Console.WriteLine("Há uma maça em cima da mesa, deseja come-lá? - Sim ou Não");
            string decisao1 = Console.ReadLine();
            
            if(decisao1 == "Sim"){
                Console.WriteLine($"{Obj1.comer()}");
            }
            else if(decisao1 == "Não"){
                Console.WriteLine($"{Obj1.comers()}");
            }
             else{
                Console.WriteLine("Resposta inválida!");
            }

            Console.WriteLine("Uma pessoa aparece e lhe ofere ajuda, aceitar?");
            string decisao2 = Console.ReadLine();

            if(decisao2 == "Sim"){
                Console.WriteLine($"{Obj2.nome}{Obj1.ajudar()}");
            }
            else if(decisao1 == "Não"){
                Console.WriteLine($"Fim de jogo - O seguranças te achara");
            }
             else{
                Console.WriteLine("Resposta inválida!");
            }






            

            Console.WriteLine("");
            Console.WriteLine("");
            
        
        }
    }
} 
