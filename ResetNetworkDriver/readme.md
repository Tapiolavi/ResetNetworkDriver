# NetworkDriver restart app

When using asus laptop the windows may mess the network adapter and this requires specifix operations to resolve this. Fail occus when laptop lid is closed or is sleep mode uses etc.
Currently best way to solve this is restart the network adapter. Manuafacer has no button to reset the adapter so this program helps to reset the network adapter in 6 sec.

## Install

1. Enable visual studio nuget pagcake manager to install automatically missing packages.
2. Build the solution with Release settings.

If no package manager:
Install packagemanager and install debencies 

If no nuget / automatic package installing:
Get nuget package from https://www.nuget.org/packages/SimpleDeviceManager/

install in your selected package manager debencies.

```
> NuGet\Install-Package SimpleDeviceManager -Version 1.0.1
```




