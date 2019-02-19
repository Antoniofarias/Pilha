using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pilha - Primeira que entra é a última que sai

            Stack<string> minhaPilha = new Stack<string>();

            minhaPilha.Push("Primeira");
            minhaPilha.Push("Segunda");
            minhaPilha.Push("Terceira");
            minhaPilha.Push("Quarta");
            minhaPilha.Push("Quinta");

            foreach (string carta in minhaPilha)
            {
                Console.WriteLine(carta);
            }
            Console.ReadKey();
        }
    }
}
// minhaPilha.Pop(); Remove o primeiro elemento da pilha