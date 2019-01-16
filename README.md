# aspnetcore.utilities ![](https://img.shields.io/github/license/iowacomputergurus/aspnetcore.utilities.svg)
| Master | Develop |
| --- | --- |
| ![Master Branch Status](https://iowacomputergurus.visualstudio.com/ICG%20Open%20Source/_apis/build/status/AspNetCore%20Utilities?branchName=master) | ![Development Branch Status](https://iowacomputergurus.visualstudio.com/ICG%20Open%20Source/_apis/build/status/AspNetCore%20Utilities?branchName=development) |

| NuGet Package | Stats |
| --- |--- |
| ICG.AspNetCore.Utilities | ![](https://img.shields.io/nuget/v/icg.aspnetcore.utilities.svg) ![](https://img.shields.io/nuget/dt/icg.aspnetcore.utilities.svg) |

A collection of helpful utilities for working with ASP.NET Core projects.  These items are used by the IowaComputerGurus Team to aid in unit testing and other common tasks

## Using ICG.AspNetCore.Utilities

### Installation

Install from NuGet

```
Install-Package ICG.AspNetCore.Utilities
```
### Register Dependencies

Inside of of your project's Startus.cs within the RegisterServices method add this line of code.

```
services.UseIcgAspNetCoreUtilities();
```

### Included Features

| Object | Purpose |
| ---- | --- |
| IGuidProvider | Provides a shim around the System.Guid object to allow for unit testing of Guid operations.  |
| IPathProvider | Provides a shim around the System.IO.Path object to allow for unit testing of path related operations | 
| ITimeProvider | Provides a shim around the System.DateTime object to allow for unit testing of date operations |
| ITimeSpanProvider | Provides a shim around the System.TimeSpan object to allow for unit testing/injection of TimeSpan operations |
| IUrlSlugGenerator | Provides a service that will take input and generate a url friendly slug from the content |

Detailed information can be found in the XML Comment documentation for the objects, we are working to add to this document as well.
