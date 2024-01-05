using System;
using System.Threading.Tasks;




namespace Operador
{
     class JogoDaVelha
   {
       public static void Play()
       {
         Console.Clear();
         Menu1();

              static void Menu1()
              {
                
                Console.WriteLine("                                                                #JOGO DA VELHA#");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("1 - JOGAR");
                Console.WriteLine("2 - VOLTAR AO MENU PRINCIPAL");
                Console.Write(":");
                int option = int.Parse(Console.ReadKey().KeyChar.ToString());
                 switch(option)
             {
                     case 1: JOGAR(); break;
                     case 2: Menu.Principal(); break;
                     default: Menu1(); break;
 
             }
              }

              static void  JOGAR()
              {
                Console.Clear();
             string[,] matriz = new string[3 , 3];

             string turno  = "x";

             List<string> indexNumeros = new List<string> {};
             int index = 1;

             int tentativas = 1;  

                
                 Console.WriteLine("                                                                #JOGO DA VELHA#");
                 Console.WriteLine("");
                 Console.WriteLine("");
            
              //  Alimentando a matriz
             for (int i = 0; i < matriz.GetLength(0); i++)

             {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                  matriz[i, j] = index.ToString();
                  indexNumeros.Add(index.ToString());
                  index++;
                }
             }

                  // imprimindo na matrz.
                  for (int i = 0; i < matriz.GetLength(0); i++)
                  {
                       for (int j = 0; j < matriz.GetLength(1); j++)
                       {
                          Console.Write($"[{matriz[i,j]}]");
                       }
                         Console.WriteLine();
                  }
                         Console.WriteLine(" ");
                         Console.Write($"JOGADOR[{turno}]: ");
                         string jogada = Console.ReadLine();

                         Console.Clear();


                          // começa o jogo
                     while (tentativas < 9)
                      {
                
                       Console.WriteLine("                                                                #JOGO DA VELHA#");
                       Console.WriteLine("");
                       Console.WriteLine("");
                
                              //  substituir o valor na sua respectiva casa
                         for(int i = 0; i < matriz.GetLength(0); i++)
                         {
                                for(int j = 0; j < matriz.GetLength(1); j++)
                                  {
                                      if(matriz[i, j] == jogada && indexNumeros.Contains(jogada))
                                      {
                                        matriz[i, j] = turno;
                                        indexNumeros.Remove(jogada);
                                      }
                                  }
                         }

                               // imprimindo na matrz.
                             for (int i = 0; i < matriz.GetLength(0); i++)
                  {
                       for (int j = 0; j < matriz.GetLength(1); j++)
                       {
                          Console.Write($"[{matriz[i,j]}]");
                       }
                         Console.WriteLine();
                  }
                          // condições de vitoria nas diagonais 
                         if (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2] ||
                               matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])
                           {
                              Console.WriteLine(""); 
                              Console.WriteLine("FIM DE JOFGO!");
                               Console.WriteLine($" O GANHADOR É [{turno}]");
                              Thread.Sleep(4000);
                              Console.Clear();
                              Menu1();
                           }
                                // condições de vitoria nas linhas
                        if (matriz[0, 0] == matriz[0, 1] && matriz[0, 1] == matriz[0, 2] ||
                            matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2] ||
                            matriz[2, 0] == matriz[2, 1] && matriz[2, 1] == matriz[2, 2])
                        
                           {
                              Console.WriteLine(""); 
                              Console.WriteLine("FIM DE JOFGO!");
                               Console.WriteLine($" O GANHADOR É [{turno}]");
                              Thread.Sleep(4000);
                              Console.Clear();
                              Menu1();
                           }

                             // condições de vitoria nas colunas
                        if (matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2, 0] ||
                            matriz[0, 1] == matriz[1, 1] && matriz[1, 1] == matriz[2, 1] ||
                            matriz[0, 2] == matriz[1, 2] && matriz[1, 2] == matriz[2, 2])
                        
                           {
                              Console.WriteLine(""); 
                              Console.WriteLine("FIM DE JOFGO!");
                               Console.WriteLine($" O GANHADOR É [{turno}]");
                              Thread.Sleep(4000);
                              Console.Clear();
                              Menu1();
                           }

                         if( turno == "x")
                         {
                              turno = "0";
                         }
                         else 
                         {
                             turno = "x";
                         }

                          Console.WriteLine(" ");
                          Console.Write($"JOGADOR[{turno}]: ");
                          jogada = Console.ReadLine();

                          
                           while(!indexNumeros.Contains(jogada))
                           {
                              Console.WriteLine();
                              Console.Write("jogada invalida. tente novamente: ");
                              jogada = Console.ReadLine();
                           }
                             
                             
                                  tentativas++;

                                Console.Clear();
                        }

                        
                        if(tentativas == 9  )
                        {
                           Console.WriteLine(""); 
                              Console.WriteLine("FIM DE JOFGO!");
                               Console.WriteLine($" SEM GANHADOR!");
                              Thread.Sleep(4000);
                              Console.Clear();
                              Menu1();

                        }
                       Console.ReadLine();
      }

      }


}

}