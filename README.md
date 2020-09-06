# Mouse Wiggle
Moves your mouse cursor for reasons...

## Wiggle Modes

**Interface**: `IWiggle`

### SpiralCenterOutCounterClockwise

Resets the cursor position to the screen center, this is guestimated based on `CoordinateConstants.MAX_CHECK_X` and `CoordinateConstants.MAX_CHECK_Y`.

All increments then follow the static value in the class: `var increment = 3;`. 

It then moves the cursor `Up`, then `Right`, then `Down` and finally `Left`. This is repeated all while holding (and updating) the cursor position state in `CurrentScreenCoordinate`.

```c#
void WiggleCursor();
```

### TopLeftTowardsCenter

Resets the cursor position to top left `x=0, y=0` then moves it down the screen at 45 degrees till `x=500, y=500`.

```c#
void WiggleCursor();
```

# References

- https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.cursor.position