using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Spielfeld
    {
        int[,] spielfeld = new int[10,10];
        public void set(int y, int x,int z)
        {
            this.spielfeld[y, x] = z;
        }
        public int get(int y, int x)
        {
            return this.spielfeld[y,x];
        }

        public void DrawField()
        {
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(spielfeld[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
