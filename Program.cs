using MouseWiggle.Enums;
using MouseWiggle.Services;
using MouseWiggle.WiggleModes;
using MouseWiggle.WiggleModes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MouseWiggle
{
    class Program
    {
        static void Main(string[] args)
        {
            var cursorService = new CursorService();

            var wiggles = new List<IWiggle>
            {
                new TopLeftTowardsCenter(),
                new SpiralCenterOutCounterClockwise(cursorService)
            };

            int wiggle = new Random().Next(0, 2);
            
            // Debug
            // wiggle = 1;

            if (Enum.TryParse(wiggle.ToString(), out WiggleModeEnums wiggleModeEnum))
            {
                wiggles
                    .First(w => w.IsMatch(wiggleModeEnum))
                    .WiggleCursor();
            }
        }
    }
}
