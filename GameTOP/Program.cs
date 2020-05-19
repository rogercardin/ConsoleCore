using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var  jogo = new jogoFoda(new Jogador("Ronaldo"));
            jogo.IniciarJogo();
        }
    }

    public class Jogador
    {
     
        
       public readonly string _Nome;

        public Jogador(string nome)
       {
           _Nome = nome;
       }

        //chuta
         public void Chuta()
        {
            Console.Write($"{_Nome} está chutando. \n");
        }
        //Corre

        public void Corre()
        {
            Console.Write($"{_Nome} está correndo.  \n");
        }

        //Passe
        public void Passa()
        {
           Console.Write($"{_Nome} está passando. \n");
        }

    }
    

   
}
