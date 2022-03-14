using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arreglo = new int[10];
            bool creciente = true;
            int numero, sitio_num=0, j=0;
            Console.WriteLine("llenar el arreglo");
            do
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write((i+1)+".Digite un numero: ");
                    arreglo[i] = int.Parse(Console.ReadLine());

                }

                for (int i = 0; i < 4; i++)
                {
                    if (arreglo[i]< arreglo[i+1])
                    {
                        creciente = true;
                    }
                    if (arreglo[i]>arreglo[i+1])
                    {
                        creciente = false;
                        break;
                    }
                }
                if (creciente==false)
                {
                    Console.WriteLine("El arreglo no esta ordenada en forma creciente, vuelva a digitarlo");
                }
            } while (creciente==false);
            Console.Write("Digite un elemento a insertar: ");
            numero = int.Parse(Console.ReadLine());

            while (arreglo[j]<numero && j<5)
            {
                sitio_num++;
                j++;
            }
            for (int i = 4; i >= sitio_num; i--)
            {
                arreglo[i + 1] = arreglo[i];
            }

            arreglo[sitio_num] = numero;
            Console.Write("el arreglo queda: ");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(arreglo[i]+" - ");
            }
            Console.WriteLine();
        }
    }
}
