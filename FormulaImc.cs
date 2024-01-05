using System;

using System.Threading;

namespace Operador
{
    class FormulaImc
        
        {
    public static void CalculoImc()
    {
          Console.Clear();
            menu();
   

       static void menu ()
         {
           Console.WriteLine("                                                                    #CALCULO IMC# ");
           Console.WriteLine("  ");
           Console.WriteLine("  ");
           Console.WriteLine(" 1 - Realizar calculo");
           Console.WriteLine(" 2 - Voltar ao menu principal");
           Console.Write("   : ");
           int nx =  int.Parse(Console.ReadKey().KeyChar.ToString());

              switch (nx)
              {
                case 1: Calculo(); break; 
                case 2: Menu.Principal();  break;
              }

          }
                 static void Calculo() 

                   {
                    
                    
                     
                     double altura, peso, imc;
                     string nome;
                     char res;
                   
 
                         try
                         {

                      do
                      {
     
                           Console.Clear();
                          Console.WriteLine("                                                                    #CALCULO IMC# ");
                          Console.WriteLine("  ");
                          Console.WriteLine("  ");
                          Console.Write("Digite o seu nome:");
                          nome = Console.ReadLine();


                          Console.Clear();
                        Console.WriteLine("                                                                    #CALCULO IMC# ");
                          Console.WriteLine("  ");
                          Console.WriteLine("  ");
                          Console.WriteLine($" {nome}, Digite a sua altura(em metros com virgula): ");
                          Console.Write(" Apenas numeros e  aperte [enter]: "); 
                          altura = double.Parse(Console.ReadLine());


                          Console.Clear();
                          Console.WriteLine("                                                                    #CALCULO IMC# ");
                          Console.WriteLine("  ");
                          Console.WriteLine("  ");
                          Console.WriteLine("  ");
                          Console.WriteLine($"            ok {nome}");
                          Console.WriteLine("  ");
                          Console.WriteLine($" Agora digite o seu peso(em kilos): "); 
                          Console.Write(" Apenas numeros e  aperte [enter]: ");         
                          peso = double.Parse(Console.ReadLine());
                          Console.Clear();

                     

                  imc = peso / (altura) *2;
                  // x = peso / (altura * 2);

                   
                     if (imc < 18.5)
                        {
                      Console.WriteLine("                                                                    #CALCULO IMC# ");
                      Console.WriteLine("  ");  
                      Console.WriteLine("  ");  
                      Console.WriteLine("                   Dados");
                      Console.WriteLine($"Nome: {nome}");
                      Console.WriteLine($"Altura: {altura} metros");
                      Console.WriteLine($"Peso: {peso} kilos");
                      Console.WriteLine($"IMC: {imc:f2}");
                      Console.WriteLine($"você está abaixo do  peso ideal ");
                        }
                          
                       
                               
                     if (imc > 18.5 &&  imc < 24.9)
                         {
                       Console.WriteLine("                                                                    #CALCULO IMC# ");
                       Console.WriteLine("  ");
                       Console.WriteLine("  ");
                       Console.WriteLine("               Dados");
                       Console.WriteLine($"Nome: {nome}");
                       Console.WriteLine($"Altura: {altura} metros");
                       Console.WriteLine($"Peso: {peso} kilos");
                       Console.WriteLine($"IMC: {imc:f2}");
                       Console.WriteLine("você está no peso ideial ");
                        } 

      
                     if (imc > 25)
                        {
                        Console.WriteLine("                                                                    #CALCULO IMC# ");
                        Console.WriteLine("  ");
                        Console.WriteLine("  ");
                        Console.Write("                  Dados:");
                        Console.Write($"Nome: {nome}");
                        Console.WriteLine($"Altura: {altura} metros");
                        Console.WriteLine($"Peso: {peso} kilos");
                        Console.WriteLine($"IMC: {imc:f2}");
                        Console.WriteLine($"você está acima do peso ideial");
                         } 
                                 
                                Console.WriteLine(" ");
                                Console.WriteLine("  ");
                                Console.Write($"NOVO calculo IMC (s/n): ");
                                res = char.Parse(Console.ReadKey().KeyChar.ToString().ToUpper());
                                             
                         }  
                                   while (res == 'S');

                                    
                                    if (res == 'n');
                                    {
                                    Console.Clear();
                                     Console.WriteLine(" #Fim do programa#");
                                     Thread.Sleep(2500);
                                      Menu.Principal();

                                   }   
                                   
                         
                   }
                      
                    catch(System.FormatException)
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
                }   
        }

        }
}