using MouseWiggle.Constants;
using MouseWiggle.Enums;
using MouseWiggle.Services.Interfaces;
using MouseWiggle.WiggleModes.Interfaces;
using System;
using System.Threading;

namespace MouseWiggle.WiggleModes
{
    public class SpiralCenterOutCounterClockwise : IWiggle
    {
        private readonly ICursorService _cursorService;

        public SpiralCenterOutCounterClockwise(ICursorService cursorService) 
        {
            _cursorService = cursorService;
        }

        public bool IsMatch(WiggleModeEnums wiggleModeEnum)
        {
            return wiggleModeEnum
                .Equals(WiggleModeEnums.SpiralCenterOutClockWise);
        }

        public void WiggleCursor()
        {
            var increment = 3;
            var counter = 0;

            var screenCoordinate = _cursorService
                .GetScreenCoordinate();

            _cursorService
                .SetPosition(screenCoordinate.CenterX, screenCoordinate.CenterY);

            var currentScreenCoordinate = new CurrentScreenCoordinate
            {
                Up = screenCoordinate.CenterY,
                Right = screenCoordinate.CenterX,
                Down = screenCoordinate.CenterY,
                Left = screenCoordinate.CenterX
            };

            while (true) 
            {
                if (Enum.TryParse(counter.ToString(), out CursorMoveEnums cursorMoveEnum))
                {
                    if (cursorMoveEnum.Equals(CursorMoveEnums.Up))
                    {
                        currentScreenCoordinate.Up += increment;

                        _cursorService
                            .SetPosition(screenCoordinate.CenterX, currentScreenCoordinate.Up);

                        Console.WriteLine("up: {0}", currentScreenCoordinate.Up);
                    }
                    if (cursorMoveEnum.Equals(CursorMoveEnums.Right))
                    {
                        currentScreenCoordinate.Right += increment;

                        _cursorService
                            .SetPosition(currentScreenCoordinate.Right, screenCoordinate.CenterY);

                        Console.WriteLine("right: {0}", currentScreenCoordinate.Right);
                    }
                    if (cursorMoveEnum.Equals(CursorMoveEnums.Down))
                    {
                        currentScreenCoordinate.Down -= increment;

                        _cursorService
                            .SetPosition(screenCoordinate.CenterX, currentScreenCoordinate.Down);

                        Console.WriteLine("down: {0}", currentScreenCoordinate.Down);
                    }
                    if (cursorMoveEnum.Equals(CursorMoveEnums.Left))
                    {
                        currentScreenCoordinate.Left -= increment;

                        _cursorService
                            .SetPosition(currentScreenCoordinate.Left, screenCoordinate.CenterY);

                        Console.WriteLine("left: {0}", currentScreenCoordinate.Left);
                    }
                }

                if (currentScreenCoordinate.Up >= screenCoordinate.MaximumY)
                {
                    currentScreenCoordinate = new CurrentScreenCoordinate
                    {
                        Up = screenCoordinate.CenterY,
                        Right = screenCoordinate.CenterX,
                        Down = screenCoordinate.CenterY,
                        Left = screenCoordinate.CenterX
                    };
                }

                Thread.Sleep(EpochConstants.TWENTY_MILLISECONDS);
                counter++;

                if (counter >= 4)
                    counter = 0;
            }
        }

        public class CurrentScreenCoordinate
        {
            public int Up { get; set; }
            public int Right { get; set; }
            public int Down { get; set; }
            public int Left { get; set; }
        }
    }
}
