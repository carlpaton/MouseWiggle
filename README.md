# Mouse Wiggle
Moves your mouse cursor for reasons...

## Wiggle Modes

**Interface**: `IWiggle`

### TopLeftTowardsCenter

Resets the cursor position to top left `x=0, y=0` then moves it down the screen at 45 degrees till `x=500, y=500`.

```c#
void WiggleCursor();
```

# References

- https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.cursor.position