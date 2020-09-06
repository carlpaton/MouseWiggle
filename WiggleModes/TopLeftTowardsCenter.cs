using MouseWiggle.Constants;
using MouseWiggle.Enums;
using MouseWiggle.Helpers;
using MouseWiggle.WiggleModes.Interfaces;
using System;
using System.Drawing;
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
            var counterPreventPowerSave = 0;

            while (true)
            {
                Console.WriteLine("Sleep... x={0} y={1}", x, y);
                Cursor.Position = new Point(x, y);

                x += 50;
                y += 50;

                if (x > 500)
                {
                    x = 0;
                    y = 0;
                    Console.Clear();
                    FirstMessage();
                }

                if (counterPreventPowerSave % 500 == 0)
                {
                    PowerHelper.PreventPowerSave();
                    Console.WriteLine("XXXXXXXXXXXXXX Ran PreventPowerSave...");
                }
                counterPreventPowerSave++;

                Thread.Sleep(EpochConstants.ONE_SECOND_IN_MILLISECONDS);
            }
        }

        private void FirstMessage() 
        {
            Console.WriteLine("TopLeftTowardsCenter");
            Console.WriteLine("");
        }
    }
}
