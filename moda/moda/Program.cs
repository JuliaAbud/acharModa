using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moda
{
    class Program
    {
        static void Main(string[] args)
        {
            // feito para inteiros diferentes de 0 e -1 e casos quando há mais de uma moda
            int auxCounter = -1;
            int counter = 0;
            int modaLenghtCounter = 0;
            int[] vetor = new int[] { 5, 6, 6, 7, 7, 7, 8 };
            int[] moda = new int[vetor.Length - 1];
            if (vetor.Length != 0)
            {
                for (int i = 0; i < vetor.Length; i++)
                {
                    counter = 0;
                    for (int j = 0; j < vetor.Length; j++)
                    {
                        if (vetor[j] == vetor[i])
                        {
                            counter++;
                        }
                    }
                    if (counter == auxCounter && moda[modaLenghtCounter] != vetor[i])
                    {
                        modaLenghtCounter++;
                        moda[modaLenghtCounter] = vetor[i];
                    }
                    if (counter > auxCounter)
                    {
                        auxCounter = counter;
                        moda[modaLenghtCounter] = vetor[i];
                    }
                }
            }
           foreach(int item in moda) {
                if (item != 0)
                {
                    Console.Write("item: ");
                    Console.WriteLine(item);
                }
                
            }
            
            Console.ReadKey();
        }
    }
}
