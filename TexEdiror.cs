using System;
using System.Threading;



namespace Operador
{

      class TexEdiror
        {

            public static void Editor()
            {
             Menu2();

           static void Menu2()
           {
             Console.Clear();
             Console.WriteLine("                                                                  #EDITOR DE TEXTO#   ");
             Console.WriteLine("");
             Console.WriteLine("");
             Console.WriteLine("O que deseja fazer?");
             Console.WriteLine("");
             Console.WriteLine("1 - Abrir arquivo");
             Console.WriteLine("2 - Criar novo arquivo");
             Console.WriteLine("0 - Voltar ao menu Principal");
             Console.WriteLine("");
             Console.Write(":");
             int option = int.Parse(Console.ReadKey().KeyChar.ToString());

             switch(option)
             {
                     case 0: Menu.Principal(); break;
                     case 1: Abrir(); break;
                     case 2: Editar(); break;
                     default: Menu2(); break;
 
             }

           }
                      static void Abrir()
                    {
                      try
                      {
                     Console.Clear();
                     Console.WriteLine("                                                                  #EDITOR DE TEXTO#   ");
                     Console.WriteLine("");
                     Console.WriteLine("");
                     Console.WriteLine(" Qual o caminho do arquivo?");
                     string path = Console.ReadLine();

                     if( path == "Escape" )
                     {
                        Menu2();
                     }

                       if( path == "escape" )
                     {
                        Menu2();
                     }
                       
                       
                       using(var file = new StreamReader(path))
                       {
                          string text = file.ReadToEnd();
                             Console.WriteLine(text);
                       }
                             Console.Write(" ");
                             Console.ReadLine();
                                   Menu2();

                      }
                          catch(ArgumentException) 
                          {
                            Console.Clear();
                            Console.WriteLine("DIGITO INVALIDO");
                            Thread.Sleep(2500);
                             Menu2();

                          }   

                           catch(System.IO.FileNotFoundException) 
                          {
                            Console.Clear();
                            Console.WriteLine("DIGITO INVALIDO");
                            Thread.Sleep(2500);
                             Menu2();

                          }       
                      }
  
                    
           
                          static void Editar()
                         {
                            Console.Clear();
                            Console.WriteLine("                                                                  #EDITOR DE TEXTO#   ");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Digite seu texto abaixo ( [ENTER] +[ESC] para voltar e salvar)");
                            Console.WriteLine("-----------------");
                            string text = "";

                            do
                            {
                                  text += Console.ReadLine();
                                  text += Environment.NewLine;

                            }

                            while(Console.ReadKey().Key != ConsoleKey.Escape);
                            Salvar(text);

                           
                         }
      
                      static void Salvar(string text)
                      {
                           Console.Clear();
                           Console.WriteLine("                                                                  #EDITOR DE TEXTO#   ");
                           Console.WriteLine("");
                           Console.WriteLine("");
                           Console.WriteLine("Digite o caminho para salvar o arquivo");
                           Console.WriteLine("Em seguida aperte [ENTER]");
                           var path = Console.ReadLine();

                           using(var file = new StreamWriter(path))
                           {
                                file.Write(text);
                           }
                                   Console.WriteLine($" Arquivo {path} salvo com sucesso!");
                                  Thread.Sleep(3000);
                                    Menu2();

                      }

                        }
        }

}