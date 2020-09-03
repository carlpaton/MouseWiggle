using MouseWiggle.Enums;

namespace MouseWiggle.WiggleModes.Interfaces
{
    public interface IWiggle
    {
        bool IsMatch(WiggleModeEnums wiggleModeEnum);

        void WiggleCursor();
    }
}
