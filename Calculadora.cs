using System;
using System.Threading;



namespace Operador
{

    class Calculadora
   {
          public static void Calculo()
          {
     Console.Clear();
     string resp;
     char operador;
     double y1, x2, resultado;

        try
        {
          
          
      do
        {
         Console.WriteLine("                                                                                 #CALCULADORA#");
         Console.WriteLine(" ");
         Console.WriteLine(" ");
         Console.Write("DIGITE O PRIMEIRO NUMERO: ");
         y1 = double.Parse(Console.ReadLine());
         Console.Clear();
    
    
         Console.WriteLine("                                                                                 #CALCULADORA#");
         Console.WriteLine(" ");
         Console.WriteLine(" ");
         Console.WriteLine("ESCOLHA O OPERADOR: ");
         Console.WriteLine(" ");
         Console.Write("      +");
         Console.WriteLine("     -");
         Console.WriteLine(" ");
         Console.Write("      * ");
         Console.Write("    /");
         Console.WriteLine(" ");
         Console.WriteLine("");
         Console.Write(":");
         operador  = char.Parse(Console.ReadKey().KeyChar.ToString());
         Console.Clear();

                    if (operador != '/' && operador != '*' && operador != '+' && operador != '-')
                    {
                        Console.Clear();
                        Console.WriteLine("                                                                    #CALCULO IMC# ");
                        Console.WriteLine("  ");
                        Console.WriteLine("  ");
                        Console.WriteLine("DIGITO INVALIDO  ");
                        Console.WriteLine("  ");
                        Console.WriteLine("  ");
                        Console.WriteLine("VOLTANDO...");
                        Thread.Sleep(2500);
                        Calculo();
                    }




                    Console.WriteLine("                                                                                 #CALCULADORA#");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.Write("DIGITE O SEGUNDO NUMERO: ");
                        x2 = double.Parse(Console.ReadLine());
                        Console.Clear();
                    
  
               if(operador == '+')
                {
                  Console.Clear();
                  Console.WriteLine("                                                                                 #CALCULADORA#");
                  Console.WriteLine(" ");
                  resultado = y1 + x2; 
                  Console.WriteLine("");
                  Console.WriteLine($" {y1} {operador} {x2} = {resultado:f2}");
                  Thread.Sleep(4000);
                 }

            
               if(operador == '-')
                {
                  Console.Clear();
                  Console.WriteLine("                                                                                 #CALCULADORA#");
                  Console.WriteLine(" ");
                  resultado = y1 - x2;
                  Console.WriteLine("");
                  Console.WriteLine($" {y1} {operador} {x2} = {resultado:f2}");
                  Thread.Sleep(4000);
                }

               if(operador == '*')
               {
                Console.Clear();
                Console.WriteLine("                                                                                 #CALCULADORA#");
                Console.WriteLine(" ");
                resultado = y1 * x2;
                Console.WriteLine("");
                Console.WriteLine($" {y1} {operador} {x2} = {resultado:f2}");
                Thread.Sleep(4000);
               }

             
               if(operador == '/')
                {
                Console.Clear();
                Console.WriteLine("                                                                                 #CALCULADORA#");
                Console.WriteLine(" ");
                resultado = y1 / x2; 
                Console.WriteLine("");
                Console.WriteLine($" {y1} {operador} {x2} = {resultado:f2}");
                Thread.Sleep(4000);
             
                }


               
         Console.Clear();
         Console.WriteLine("                                                                                 #CALCULADORA#");
         Console.WriteLine(" ");
         Console.WriteLine("");
         Console.Write("NOVA OPERAÇÃO s/n?: ");
         resp = Console.ReadKey().KeyChar.ToString();
         Console.WriteLine(" ");
         Console.Clear();

                   

                }
            
             while(resp == "s");

                



                if (resp == "n")
              {
               Console.Clear();
               Console.WriteLine("                                                                                 #CALCULADORA#");
               Console.WriteLine(" ");
               Console.WriteLine(" ");
               Console.WriteLine("FIM");
               Thread.Sleep(2500);
               Menu.Principal();
               
            }
                 if(resp != "s"  || resp != "n")
               {
                 Console.WriteLine("                                                                                 #CALCULADORA#");
                 Console.WriteLine(" ");
                 Console.WriteLine("");
                 Console.WriteLine("OPÇÃO INVALIDA");
                 Console.WriteLine(" ");
                 Console.WriteLine("VOLTANDO PARA O MENU PRINCIPAL");
                 Thread.Sleep(2500);
                 Menu.Principal();
          
                    
               }
                



            }
            catch (System.FormatException)
                {
                     Console.Clear();
                     Console.WriteLine("                                                                                 #CALCULADORA#");
                     Console.WriteLine(" ");
                     Console.WriteLine(" ");
                     Console.WriteLine("DIGITO INVALIDO");
                     Thread.Sleep(2500);
                     Calculo();

                }
              
        }

}

}