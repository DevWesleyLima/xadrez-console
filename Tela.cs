using System;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void PrintChessboard(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Lines; i++)
            {
                for (int j = 0; j < tab.Columns; j++)
                {
                    if (tab.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.Peca(i, j) + " ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
