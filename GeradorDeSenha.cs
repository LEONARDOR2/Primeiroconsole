
using System;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace Operador
{
     class GeradorDeSenha
         {

           public static void Gerador()
            {
          string resposta;
          try
          {
          do{
           Console.Clear();
           Console.WriteLine("                                                                       #GERADOR DE SENHA#");
           Console.WriteLine(" ");
           Console.WriteLine(" ");
           Console.WriteLine("Quantos digitos a senha vai ter?");
           Console.WriteLine("Digite a quantidade e aperte [enter] ");
           Console.Write(": ");
             int qtd = int.Parse(Console.ReadLine());


             string caracteresPossiveis = 
             "ABCDEFGHILKLMNOPQRSUVWXYZÇ" +
             "ABCDEFGHILKLMNOPQRSUVWXYZÇ".ToLower() +
             "0123456789" + "%$#!" ;

              Random sorteio = new Random();
              int NumeroSorteio = 0;
              StringBuilder password = new StringBuilder();

             for(int t = 0; t < qtd; t++)
             {
                        NumeroSorteio = sorteio.Next(0, caracteresPossiveis.Length -1);
                        password.Append(caracteresPossiveis[NumeroSorteio]);
             }



                Console.Clear();
                Console.WriteLine("                                                                       #GERADOR DE SENHA#");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine($"SENHA GERADA: {password}");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.Write("Deseja gerar uma nova senha?(s/n):");
                 resposta = Console.ReadKey().KeyChar.ToString().ToLower();

                
         }
                     while(resposta == "s");
                     

                       if(resposta == "n") 
                       {
                         Console.Clear();
                         Console.WriteLine("                                                                       #GERADOR DE SENHA#");
                         Console.WriteLine(" ");
                         Console.WriteLine(" ");
                         Console.WriteLine("VOLTANDO AO MENU PRINCIPAL...");
                         Thread.Sleep(2500);
                        Menu.Principal();
                       }

                        if(resposta != "n" || resposta !="s")
                       {
                         Console.Clear();
                         Console.WriteLine("                                                                       #GERADOR DE SENHA#");
                         Console.WriteLine(" ");
                         Console.WriteLine(" ");
                         Console.WriteLine("DIGITO INVALIDO");
                         Console.WriteLine(" ");
                         Console.WriteLine(" ");
                         Console.WriteLine("VOLTANDO AO MENU PRINCIPAL...");
                         Thread.Sleep(2500);
                        Menu.Principal();
                       }
          }        catch(FormatException)
                       {
                         Console.Clear();
                         Console.WriteLine("                                                                       #GERADOR DE SENHA#");
                         Console.WriteLine(" ");
                         Console.WriteLine(" ");
                         Console.WriteLine("DIGITO INVALIDO");
                         Console.WriteLine(" ");
                         Console.WriteLine("RECOMEÇANDO... ");
                         Thread.Sleep(2500);
                         Gerador();

                       }
           
                    
    }
   
         }
}

