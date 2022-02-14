using System;

namespace ProjetoRoboNovo.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fechar = "";
            while (fechar != "FECHAR")
            {

                //ENTRADA DA AREA
                int x = -1;
                int y = -1;
                while (x < 0 || y < 0)
                {
                    Console.WriteLine("Bem-Vindo ao Projeto Tupiniquim!");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Primeiro temos que definir o tamanho da área de movimento do robo em coordenadas X e Y");
                    Console.WriteLine("ESCREVA AS COORDENADAS X E Y RESPECTIVAMENTE DA SEGUINTE FORMA: EXEMPLO -> 5 5");

                    string[] tamanhoDaArea = Console.ReadLine().Split(' ');

                    //teste de variaveis 1
                    bool testeArea = false;
                    if (tamanhoDaArea.Length <= 2)
                    {
                        testeArea = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("---ERRO--- ao declarar as posiçoes X ou Y, tente utilizar numeros inteiros maiores que 0");
                        Console.WriteLine("Aperte ENTER para tentar novamente!");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    //validaçao de variaveis
                    if (int.TryParse(tamanhoDaArea[0], out x) && int.TryParse(tamanhoDaArea[1], out y) && testeArea == true)
                    {

                        x = Convert.ToInt32(tamanhoDaArea[0]);
                        y = Convert.ToInt32(tamanhoDaArea[1]);

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("---ERRO--- ao declarar as posiçoes X ou Y, tente utilizar numeros inteiros maiores que 0");
                        Console.WriteLine("Aperte ENTER para tentar novamente!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }



                //ENTRADA DA POSIÇAO INICIAL DO ROBO
                int posicaoX = -1;
                int posicaoY = -1;
                string direcao = "";
                while (posicaoX < 0 || posicaoY < 0 || direcao != "")
                {
                    Console.Clear();
                    Console.WriteLine("Agora vamos declarar a posição inicial do robo dentro do campo.");
                    Console.WriteLine("escreva as posiçoes X Y e direçao do robo respectivamente");
                    Console.WriteLine("sendo X e Y numeros inteiros");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("e direçao Norte - N ");
                    Console.WriteLine("e direçao Sul - S ");
                    Console.WriteLine("e direçao Leste - L ");
                    Console.WriteLine("e direçao Oeste - O ");
                    Console.WriteLine("----------------------------");

                    string[] strPosicaoInicial = Console.ReadLine().Split(' ');
                    //teste de variaveis 2

                    bool testeArea2 = false;
                    if (strPosicaoInicial.Length <= 3)
                    {
                        testeArea2 = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("OPA, ALGO DEU ERRADO, CERTIFIQUE-SE DE DETERMINAR VALORES CORRETOS PARA AS VARIAVEIS !");
                        Console.WriteLine("TENTE NOVAMENTE, PROSSIONE ENTER");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }


                    //TESTE DIRECAO
                    if (strPosicaoInicial[2] != "N" && strPosicaoInicial[2] != "S" && strPosicaoInicial[2] != "L" && strPosicaoInicial[2] != "O")
                    {
                        Console.Clear();
                        Console.WriteLine("OPA, ALGO DEU ERRADO, CERTIFIQUE-SE DE DETERMINAR VALORES CORRETOS PARA AS VARIAVEIS !");
                        Console.WriteLine("TENTE NOVAMENTE, PROSSIONE ENTER");
                        Console.ReadLine();
                        Console.Clear();
                        direcao = "";
                        continue;
                    }

                    //VALORES INTEIROS     
                    if (int.TryParse(strPosicaoInicial[0], out posicaoX) && int.TryParse(strPosicaoInicial[1], out posicaoY) && testeArea2 == true)
                    {
                        posicaoX = Convert.ToInt32(strPosicaoInicial[0]);
                        posicaoY = Convert.ToInt32(strPosicaoInicial[1]);
                        direcao = strPosicaoInicial[2];
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("OPA, ALGO DEU ERRADO, CERTIFIQUE-SE DE DETERMINAR VALORES CORRETOS PARA AS VARIAVEIS !");
                        Console.WriteLine("TENTE NOVAMENTE, PROSSIONE ENTER");
                        Console.ReadLine();
                        Console.Clear();
                        direcao = "";
                        continue;
                    }

                    //TESTE DE AREA
                    if (Convert.ToInt32(strPosicaoInicial[0]) > x || Convert.ToInt32(strPosicaoInicial[1]) > y)
                    {
                        Console.Clear();
                        Console.WriteLine("OPA, ALGO DEU ERRADO, CERTIFIQUE-SE DE DETERMINAR VALORES CORRETOS PARA AS VARIAVEIS !");
                        Console.WriteLine("TENTE NOVAMENTE, PROSSIONE ENTER");
                        Console.ReadLine();
                        Console.Clear();
                        direcao = "";
                        posicaoX = -1;
                        posicaoY = -1;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }



                //MOVIMENTO DO ROBO
                string sair = "S";
                while (sair != "")
                {

                    Console.Clear();
                    Console.WriteLine("SUA POSIÇAO INICIAL FOI CONCLUIDA.");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Posição inicial do robo: " + posicaoX + "-" + posicaoY + "-" + direcao);
                    Console.WriteLine("Vamos movimentar o robo utilizando a seguinte forma");
                    Console.WriteLine("E - Movimenta o robo 90° para esquerda");
                    Console.WriteLine("D - Movimenta o robo 90° para direita");
                    Console.WriteLine("M - Movimenta o robo para frente");
                    Console.WriteLine("ESCREVA OS MOVIMENTOS DO SEU ROBO");

                    string comando = Console.ReadLine();
                    char[] posicaoFinal = comando.ToCharArray();
                    int posicaoFinalX = posicaoX;
                    int posicaoFinalY = posicaoY;



                    for (int i = 0; i < posicaoFinal.Length; i++)
                    {

                        if (posicaoFinal[i] == 'E')
                        {
                            if (direcao == "N")
                            {
                                direcao = "O";
                            }
                            else if (direcao == "O")
                            {
                                direcao = "S";
                            }
                            else if (direcao == "S")
                            {
                                direcao = "L";
                            }
                            else if (direcao == "L")
                            {
                                direcao = "N";
                            }
                        }


                        else if (posicaoFinal[i] == 'D')
                        {
                            if (direcao == "N")
                            {
                                direcao = "L";
                            }
                            else if (direcao == "O")
                            {
                                direcao = "N";
                            }
                            else if (direcao == "S")
                            {
                                direcao = "O";
                            }
                            else if (direcao == "L")
                            {
                                direcao = "S";
                            }
                        }


                        else if (posicaoFinal[i] == 'M')
                        {
                            if (direcao == "N")
                            {
                                posicaoFinalY = posicaoFinalY + 1;
                            }
                            else if (direcao == "O")
                            {
                                posicaoFinalX = posicaoFinalX - 1;
                            }
                            else if (direcao == "S")
                            {
                                posicaoFinalY = posicaoFinalY - 1;
                            }
                            else if (direcao == "L")
                            {
                                posicaoFinalX = posicaoFinalX + 1;

                            }

                        }

                    }
                    if (posicaoFinalX > x || posicaoFinalY > y || posicaoFinalX < 0 || posicaoFinalY < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("ERRO AO EXECUTAR O COMANDO, VOCE SAIU FORA DA DISTANCIA MAXIMA PERMITIDA.");
                        Console.WriteLine("PRESSIONE ENTER PARA REINICIAR O PROGRAMA!!!");
                        Console.ReadLine();
                        Console.Clear();
                        continue;

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Seu robo chegou até a posiçao: " + posicaoFinalX + "-" + posicaoFinalY + "-" + direcao);
                        Console.WriteLine("ESCREVA 'S' PARA REFAZER OUTRO MOVIMENTO");
                        Console.WriteLine("APERTE ENTER PARA ENCERRAR O ROBO");
                        sair = Console.ReadLine();
                        if (sair == "S")
                        {
                            continue;
                        }

                    }
                }

                Console.Clear();
                Console.WriteLine("ESCREVA 'FECHAR' PARA ENCERRAR O ROBO");
                Console.WriteLine("OU APERTE ENTER PARA REINICIAR O ROBO");
                fechar = Console.ReadLine();

            }
        }
    }
}
