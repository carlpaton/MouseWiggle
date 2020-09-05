using MouseWiggle.Constants;
using MouseWiggle.Entities;
using MouseWiggle.Services.Interfaces;
using System.Drawing;
using System.Windows.Forms;

namespace MouseWiggle.Services
{
    public class CursorService : ICursorService
    {
        public ScreenCoordinate GetScreenCoordinate()
        {
            var currentPosition = Cursor.Position;

            Cursor.Position = new Point(
                CoordinateConstants.MAX_CHECK_X, 
                CoordinateConstants.MAX_CHECK_Y);

            var maximumPosition = Cursor.Position;

            Cursor.Position = new Point(
                currentPosition.X,
                currentPosition.Y);

            return new ScreenCoordinate() 
            { 
                CurrentX = currentPosition.X,
                CurrentY = currentPosition.Y,
                
                MaximumX = maximumPosition.X,
                MaximumY = maximumPosition.Y,

                CenterX = maximumPosition.X / 2,
                CenterY = maximumPosition.Y / 2
            };
        }

        public void SetPosition(int x, int y)
        {
            Cursor.Position = new Point(x, y);
        }
    }
}
