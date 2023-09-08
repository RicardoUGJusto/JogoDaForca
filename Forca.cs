using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_forca
{
    internal class Forca
    {
        public static void forca()
        {
            char[,] forc = new char[7, 5];

            forc[0, 0] = '|';
            forc[0, 1] = '-';
            forc[0, 2] = '-';
            forc[0, 3] = '|';
            forc[0, 4] = ' ';

            forc[1, 0] = '|';
            forc[1, 1] = ' ';
            forc[1, 2] = ' ';
            forc[1, 3] = 'O';
            forc[1, 4] = ' ';

            forc[2, 0] = '|';
            forc[2, 1] = ' ';
            forc[2, 2] = '<';
            forc[2, 3] = '|';
            forc[2, 4] = '>';

            forc[3, 0] = '|';
            forc[3, 1] = ' ';
            forc[3, 2] = '/';
            forc[3, 3] = '|';
            forc[3, 4] = ' ';

            forc[4, 0] = '|';
            forc[4, 1] = ' ';
            forc[4, 2] = ' ';
            forc[4, 3] = ' ';
            forc[4, 4] = ' ';

            forc[5, 0] = '|';
            forc[5, 1] = ' ';
            forc[5, 2] = ' ';
            forc[5, 3] = ' ';
            forc[5, 4] = ' ';

            forc[6, 0] = '-';
            forc[6, 1] = '-';
            forc[6, 2] = '-';
            forc[6, 3] = ' ';
            forc[6, 4] = ' ';

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(forc[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
