using System;
using System.Threading;
using System.Windows.Forms;

namespace MouseWiggle
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 0;
            var y = 0;

            while (true) 
            {
                Cursor.Position = new System.Drawing.Point(x, y);

                x += 50;
                y += 50;

                if (x >= 500) 
                {
                    x = 100;
                    y = 100;
                    Console.Clear();
                }

                Console.WriteLine("Sleep for a minute... x={0} y={1}", x, y);
                Thread.Sleep(60000); // 60000 = 1 minute
            }
        }
    }
}
