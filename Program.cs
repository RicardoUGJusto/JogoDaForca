using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_forca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra para jogar.");
            string p = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Se errar 6 vezes o Palitito será enforcado!");
            Forca.forca();

            Console.ReadKey();
        }
    }
}
