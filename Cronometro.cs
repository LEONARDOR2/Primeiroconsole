using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Text;
using System.ComponentModel.Design;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Operador
{

     class Cronometro
           {

            public static void contador()
            {
              Console.Clear();

             Console.WriteLine("                                                                               #CRONOMETRO#");
              Menuu();
            }
           static void Menuu()
                {
                         Console.Clear();
                         Console.WriteLine("                                                       CRONOMETRO");
                         Console.WriteLine(" ");
                         Console.WriteLine("        Menu  ");
                         Console.WriteLine(" ");
                         Console.WriteLine(" S = Segundos => 10s = 10 segundos");
                         Console.WriteLine(" M = Minuto => 1m = 1 minuto");
                         Console.WriteLine(" H = Hora => 1h = 1 hora ");
                         Console.WriteLine(" 00 - Menu Principal");
                         Console.WriteLine(" Escolha a opção e aperte [ENTER]");
                         Console.WriteLine(" ");
                         Console.Write(" ->:"); 

                         string data = Console.ReadLine().ToLower();
                         char type = char.Parse(data.Substring(data.Length-1, 1));
                         int time = int.Parse(data.Substring(0, data.Length -1));
                         int multiplier = 1;

                            if ( type == 'm')

                           multiplier = 60;
                             

                            if ( type == 'h')
                            
                            multiplier = 3600;
                            

                            if ( data == "X" || time == 0) 
                             Menu.Principal();

                           

                            PreStart(time * multiplier);
                         
                }
              
                                static void PreStart( int time)
                                 {
                                   
                                   Console.Clear();
                                   Console.WriteLine("                                                                               #CRONOMETRO#");
                                   Console.WriteLine(" ");
                                   Console.WriteLine(" Ready...");
                                   Thread.Sleep(1000);
                                   Console.WriteLine(" Set ...");
                                   Thread.Sleep(1000);
                                   Console.WriteLine(" Go ...");
                                   Thread.Sleep(2500);

                                   start(time);

                 }

               static void start(int time)
               {

                    int currentTime =0;
                    

                    while  (currentTime != time)
                    {
                      Console.Clear();
                      currentTime++;
                      Console.WriteLine(" ");
                      Console.WriteLine(" ");
                      Console.WriteLine(" ");
                      Console.WriteLine(" ");
                      Console.WriteLine(" ");
                      Console.WriteLine(" ");
                      Console.WriteLine(" ");
                      Console.WriteLine(" ");
                      Console.WriteLine(" ");
                      Console.WriteLine(" ");
                      Console.WriteLine($"                                                        {currentTime}");
                      Thread.Sleep(1000);
                      }
                     Console.Clear();
                     Console.WriteLine("cronometro finalizado");
                     Thread.Sleep(3500);
                     Menuu();
               }
            
           }

       
}       

