using System;
using System.Threading;
using System.Text;
using System.Text.RegularExpressions;

namespace Operador
{

    class EditorDeTextoHtml
     {     

        public  static void EditorHtml()
        {
          Console.Clear();

           try
             {
           show();

                
                 static  void show()
                   {
                       Console.Clear();
                       Console. BackgroundColor = ConsoleColor.Red;
                       Console. ForegroundColor = ConsoleColor.Black;

                       DrawScreen();
                       WriteOptions();

                       var option = short.Parse(Console.ReadLine());
                       HandleMenuOption(option);
                 
                    

                       static void DrawScreen()
                       {
                              Console.Write("+");
                              for( int i = 0; i <= 60; i++)
                                Console.Write("-");
                              
                              Console.Write("+");
                              Console.Write("\n");

                              for( int lines =0; lines <=20; lines++)
                              {
                                Console.Write("|");
                                 for( int i = 0; i <= 60; i++)
                                   Console.Write(" ");

                                   Console.Write("|");
                                   Console.Write("\n");

                              }


                               Console.Write("+");
                              for( int i = 0; i <= 60; i++)
                                Console.Write("-");
                              
                              Console.Write("+");
                              Console.Write("\n");
                       }

                     
                         
                       static void  WriteOptions()
                       {
                           Console.SetCursorPosition(3, 2);
                           Console.WriteLine("        #Editor HTML#"            );
                           
                           Console.SetCursorPosition(3, 3);
                           Console.WriteLine(" ");
                           Console.SetCursorPosition(3, 4);
                           Console.WriteLine("Selecione uma opção abaixo");
                           Console.SetCursorPosition(3, 6);
                           Console.WriteLine("1 - Novo arquivo");
                           Console.SetCursorPosition(3, 7);
                           Console.WriteLine("2 - Abrir");
                           Console.SetCursorPosition(3, 8);
                           Console.WriteLine("0 - Sair");
                           Console.SetCursorPosition(3, 10);
                           Console.Write("Opção:");

                       }
   
                  

                          

                        static void HandleMenuOption(short option)
                        {
                            switch(option)
                            {
                              case 1: Editar(); break;
                              case 2: Abrir();  break;
                              case 0: Menu.Principal(); break;
                              
                            }
                              }
                        }

                 
                       
                            static void  Editar(string text ="")
                            {
                             Console.Clear();
                             Console.BackgroundColor = ConsoleColor.Yellow;
                             Console.ForegroundColor = ConsoleColor.Black;
                             Console.Clear();
                             Console.WriteLine("                                                      #Editor HTML#");
                             Console.WriteLine(" ");
                             Console.WriteLine(" ");
                             Console.WriteLine("     EDITAR");
                             Console.WriteLine(" [Enter] + [Esc] para salvar.");
                             Console.WriteLine(" Copie o codigo [ctrl] + [V]");
                             Console.WriteLine(" ");
                             Console.Write(" ");
                             Console.Write(text);
                             Console.Write(": ");
                              start();
                             
                         

                          static void start()
                          {
                              var file = new StringBuilder();

                              do
                              {
                                  
                                  file.Append(Console.ReadLine());
                                  file.Append(Environment.NewLine);
                                 
                              }  while (Console.ReadKey().Key != ConsoleKey.Escape);

                                Console.WriteLine("--------------");
                               Visualizador(file.ToString());

                          }
                        
                            
              
                            
                                 static void Visualizador(string text)
                                 {
                                   Console.Clear();
                                   Console.BackgroundColor = ConsoleColor.Blue;
                                   Console.ForegroundColor = ConsoleColor.Black;
                                   Console.Clear();
                                   Console.WriteLine("                                                          #Editor HTML#");
                                   Console.WriteLine(" ");
                                   Console.WriteLine(" ");
                                   Console.WriteLine("      MODO DE VISUALIAZÃO:");
                                   Console.WriteLine(" ");
                                   Console.WriteLine(" ");
                                   Replace(text);
                                   Console.WriteLine(" ");
                                   Console.WriteLine(" ");
                                   Console.WriteLine(" ");
                                   Console.WriteLine(" ");
                                  //  Console.WriteLine("      PRESSIONE QUALQUER TECLA");
                                  //  Console.ReadKey();
                                 
                                   
                                 
                                  Console.WriteLine(" ");
                                   Console.WriteLine(" ");
                               Console.Write("Deseja salvar o arquivo?(s/n): ");
                               string resposta2 = Console.ReadLine().ToString().ToLower();

                               if( resposta2 == "s")
                               Salvar(text);

                               if( resposta2 == "n")
                                Editar(text);

                                if( resposta2 !="n" || resposta2 !="s" )
                                {
                                       Console.WriteLine(" ");
                                       Console.WriteLine("DIGITO INVALIDO! ");
                                       Console.WriteLine(" ");
                                       Console.WriteLine("VOLTANDO... ");
                                       Thread.Sleep(2500); 
                                       Editar(text);
                                 }   
                                
                              //  if(text == string.Empty)
                              //  {
                                  // Console.WriteLine(" NÃO EXISTE NENHUM CAMINHO SALVO");
                                  // Console.WriteLine(" ");
                                  // Console.WriteLine("RETORNANDO ");
                                  // Thread.Sleep(2500);
                              //  }
                           }
                                  static void Replace(string text)
                                  {

                                       var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
                                       var words = text.Split(' ');

                                       for( var i = 0; i < words.Length; i++)
                                       {
                                          if(strong.IsMatch(words[i]))
                                          {
                                             Console.ForegroundColor = ConsoleColor.Green;
                                             Console.Write(
                                                  words[i].Substring(
                                                      words[i].IndexOf('>') +1,
                                                      (
                                                        (words[i].LastIndexOf('<') -1) -
                                                       words[i].IndexOf('>')
                                                      )
                                                  )
                                             );
                                             Console.Write("");
                                          
                                          } else {
                                             Console.ForegroundColor = ConsoleColor.Black;
                                             Console.Write(words[i]);
                                             Console.Write(" ");
                                          }
                                       }
                                  } 
                                 
                            
                               }        
                                       
                                             
                        static void Salvar(string text)
                      {
                           Console.Clear();
                           Console.WriteLine("                                                      #Editor HTML#");
                           Console.WriteLine(" ");
                           Console.WriteLine(" ");
                           Console.WriteLine("Qual caminho para salvar o arquivo");
                           var path = Console.ReadLine();

                           using(var file = new StreamWriter(path))
                             {
                                file.Write(text);
                               }
                                   Console.WriteLine($" Arquivo {path} salvo com sucesso!");
                                   Console.WriteLine("");
                                   Console.WriteLine("PRESSIONE [ENTER] PARA VOLTAR AO MENU");
                                   Console.ReadLine();
                                   EditorHtml();
                                    

                      }

                           static void Abrir()
                           {
                               Console.Clear();
                               Console.WriteLine("Qual o caminho do arquivo? ");
                               Console.Write(": ");
                               string path = Console.ReadLine();

                               using(var file = new StreamReader(path))
                               {
                                   string text = file.ReadToEnd();
                                   Console.WriteLine(text);
                                   
                                   
                               }
                               
                               
                                    Console.WriteLine("");
                                    Console.WriteLine("PRESSIONE [ENTER] PARA VOLTAR AO MENU");
                                    Console.ReadLine();
                                    EditorHtml();

                           }
                                 

                         } catch(FormatException)
                          {
                            Console.Clear();
                            Console.WriteLine("                                                      #Editor HTML#");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.Write("    DIGITO INVALIDO");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.Write("    TENTE NOVAMENTE...");
                            Thread.Sleep(2500);
                            EditorHtml();
                          }
                           
                            catch(System.IO.IOException)
                           {
                             Console.Clear();
                            Console.WriteLine("                                                      #Editor HTML#");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.Write("    CAMINHO INVALIDO");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.Write("    TENTE NOVAMENTE...");
                            Thread.Sleep(2500);
                            EditorHtml();
                          }

                          catch(System.UnauthorizedAccessException)
                           {
                             Console.Clear();
                            Console.WriteLine("                                                      #Editor HTML#");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.Write("    CAMINHO INVALIDO");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.Write("    TENTE NOVAMENTE...");
                            Thread.Sleep(2500);
                            EditorHtml();
                          }
                       }

                              
}
                           

  }
