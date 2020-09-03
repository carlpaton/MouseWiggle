using MouseWiggle.Enums;
using MouseWiggle.WiggleModes;
using MouseWiggle.WiggleModes.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MouseWiggle
{
    class Program
    {
        static void Main(string[] args)
        {
            var wiggles = new List<IWiggle>
            {
                new TopLeftTowardsCenter()
            };

            wiggles
                .First(w => w.IsMatch(WiggleModeEnums.TopLeftTowardsCenter))
                .WiggleCursor();
        }
    }
}
