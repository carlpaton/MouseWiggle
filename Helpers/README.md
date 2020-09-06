## PowerHelper

**Class**: `PowerHelper`

### PreventPowerSave

> The system automatically detects activities such as local keyboard or mouse input, server activity, and changing window focus. Activities that are not automatically detected include disk or CPU activity and video display.

> Calling SetThreadExecutionState without ES_CONTINUOUS simply resets the idle timer; to keep the display or system in the working state, the thread must call SetThreadExecutionState periodically.

```c#
void PreventPowerSave();
```

# References

- https://docs.microsoft.com/en-us/windows/win32/api/winbase/nf-winbase-setthreadexecutionstate?redirectedfrom=MSDN
- https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/extern
- https://stackoverflow.com/questions/5870280/setthreadexecutionstate-is-not-working-when-called-from-windows-service
- https://stackoverflow.com/questions/38282770/stop-screensaver-programmatically
- https://stackoverflow.com/questions/49045701/prevent-screen-from-sleeping-with-c-sharp