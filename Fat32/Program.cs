using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fat32
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int[] archivos = new int[] { 300, 400};
            int total = 0;
            int archivoSub = 0;
            archivoSub = archivos[0];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 255;
            }
            foreach (var arch in archivos)
            {

                for (int i = 0; i < array.Length; i++)
                {
                    if (archivoSub >= array[i])
                    {
                        if (array[i] != 255)
                        {
                            i++;
                        }
                        else
                        {
                            archivoSub = archivoSub - array[i];
                            array[i] = archivoSub;
                            total = array[i] + total;
                        }
                    }
                    else if (archivoSub <= array[i])
                    {
                        if (array[i] != 255)
                        {
                            i++;
                        }
                        else
                        {
                            archivoSub = array[i] - archivoSub;
                            array[i] = archivoSub;
                            total = array[i] + total;
                        }
                    }
                    
                    if (total == arch)
                    {
                        total = 0;
                        archivoSub = archivos[1];
                        break;
                    }
                }
            }
            Console.WriteLine("Se utilizaron 2 archivos");
            foreach (var item in array)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
