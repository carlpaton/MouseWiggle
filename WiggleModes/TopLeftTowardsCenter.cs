using MouseWiggle.Constants;
using MouseWiggle.Enums;
using MouseWiggle.WiggleModes.Interfaces;
using System;
using System.Threading;
using System.Windows.Forms;

namespace MouseWiggle.WiggleModes
{
    public class TopLeftTowardsCenter : IWiggle
    {
        public bool IsMatch(WiggleModeEnums wiggleModeEnum)
        {
            return wiggleModeEnum
                .Equals(WiggleModeEnums.TopLeftTowardsCenter);
        }

        public void WiggleCursor()
        {
            FirstMessage();
            var x = 0;
            var y = 0;

            while (true)
            {
                Console.WriteLine("Sleep for a minute... x={0} y={1}", x, y);
                Cursor.Position = new System.Drawing.Point(x, y);

                x += 50;
                y += 50;

                if (x >= 500)
                {
                    x = 0;
                    y = 0;
                    Console.Clear();
                    FirstMessage();
                }

                Thread.Sleep(EpochConstants.ONE_MINUTE_IN_MILLISECONDS);
            }
        }

        private void FirstMessage() 
        {
            Console.WriteLine("TopLeftTowardsCenter");
            Console.WriteLine("");
        }
    }
}
