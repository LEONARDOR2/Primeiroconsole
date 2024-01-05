using System;


namespace Operador
{
    class Menu
             {

                public static void Principal()
                 {
                 Console.Clear();
                 Console. ForegroundColor = ConsoleColor.Red;

                 var data1 = DateTime.Now;

                 try
                 {

                 Console.WriteLine("                                                                                #OPERADOR#");
                 Console.WriteLine($"                                       {data1}");
                 Console.WriteLine(" ");
                 Console.WriteLine(" Menu Principal ");
                 Console.WriteLine(" ");
                 Console.WriteLine("");
                 Console.WriteLine("1 - Calculadora");
                 Console.WriteLine("2 - Cronometro");
                 Console.WriteLine("3 - Calculo Imc");
                 Console.WriteLine("4 - Editor de Texto");
                 Console.WriteLine("5 - Jogo da Velha");
                 Console.WriteLine("6 - Gerador de Senha ");
                 Console.WriteLine("7 - Editor Html ");
                 Console.WriteLine("0 - sair");

                 Console.WriteLine("-----------------------");
                 Console.Write("Selecone uma opção:");
                 int  res = int.Parse(Console.ReadKey().KeyChar.ToString());

                 switch (res)
                 {
                    case 1: Calculadora.Calculo(); break;
                    case 2: Cronometro.contador(); break;
                    case 3: FormulaImc.CalculoImc(); break;
                    case 4: TexEdiror.Editor(); break;
                    case 5: JogoDaVelha.Play(); break;
                    case 6: GeradorDeSenha.Gerador(); break;
                    case 7: EditorDeTextoHtml.EditorHtml(); break;
                    
                    case 0:
                    Console.Clear();
                    Console.WriteLine("                                                                                #OPERADOR#");
                    Console.WriteLine($"                                       {data1}");
                    Console.WriteLine(" ");
                    Console.WriteLine("FINALIZANDO...");
                    Thread.Sleep(2500);
                    Console.Clear();
                    System.Environment.Exit(0); break;
                    default: Principal(); break;
                 }
                          
                 }
                 catch(System.FormatException)
                      {
                          Console.Clear();
                          Console.WriteLine("                                                                                #OPERADOR#");
                          Console.WriteLine($"                                       {data1}");
                          Console.WriteLine(" ");
                          Console.WriteLine("DIGITO INVALIDO  ");
                          Console.WriteLine("  ");
                          Console.WriteLine("  ");
                          Console.WriteLine("VOLTANDO...");
                          Thread.Sleep(2500);
                          Principal();
                          
                      }

             }
}

}