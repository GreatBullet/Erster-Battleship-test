using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Controller
    {
        private ConsoleKeyInfo key;
        bool Running= true;
        int posx= 5, posy= 5;
    
        public void InputLoop()
        {
            Spielfeld s1 = new Spielfeld();
            while (Running)
            {
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if(posx==0)
                        {
                            Console.WriteLine("dont do that");
                        }
                        else
                        {
                            s1.set(posy, posx, 0);
                            s1.set(posy, --posx, 1);
                            Console.Clear();
                            s1.DrawField();
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        if (posx == 9)
                        {
                            Console.WriteLine("dont do that");
                        }
                        else
                        {
                            s1.set(posy, posx, 0);
                            s1.set(posy, ++posx, 1);
                            Console.Clear();
                            s1.DrawField();
                        }
                        break;

                    case ConsoleKey.UpArrow:
                        if (posy == 0)
                        {
                            Console.WriteLine("dont do that");
                        }
                        else
                        {
                            s1.set(posy, posx, 0);
                            s1.set(--posy, posx, 1);
                            Console.Clear();
                            s1.DrawField();
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if(posy==9)
                        {
                            Console.WriteLine("dont do that");
                        }
                        else
                        {
                            s1.set(posy, posx, 0);
                            s1.set(++posy, posx, 1);
                            Console.Clear();
                            s1.DrawField();
                        }
                        break;

                }

            }
        }
    }
}
