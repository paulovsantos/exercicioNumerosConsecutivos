using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace NumerosConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] array = new int[] { 5, 3, 5, 8, 9, 10, 11, 15, 18, 23 };

            NumerosConsecutivos(array);

            static void NumerosConsecutivos(int[] array)
            {


                for (int i = 0; i <= array.Length - 1; i++)
                {
                    if (i == array.Length - 1 && array[i - 1] - array[i] == -1)
                    {
                        Console.WriteLine(array[i]);
                        continue;
                    }

                    if (i != array.Length - 1 && (array[i] - array[i + 1] == -1 || array[i] - array[i + 1] == 1))
                    {
                        Console.Write(array[i]);

                    }

                }

            }

        }
    }
}
    