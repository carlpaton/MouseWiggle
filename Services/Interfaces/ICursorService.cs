using MouseWiggle.Entities;

namespace MouseWiggle.Services.Interfaces
{
    public interface ICursorService
    {
        ScreenCoordinate GetScreenCoordinate();

        void SetPosition(int x, int y);
    }
}
