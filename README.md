# aspnetcore.utilities
| Master | Development |
| --- | --- |
| ![Master Branch Status](https://iowacomputergurus.visualstudio.com/ICG%20Open%20Source/_apis/build/status/AspNetCore%20Utilities?branchName=master) | ![Development Branch Status](https://iowacomputergurus.visualstudio.com/ICG%20Open%20Source/_apis/build/status/AspNetCore%20Utilities?branchName=development) |

A collection of helpful utilities for working with ASP.NET Core projects.  These items are used by the IowaComputerGurus Team to aid in unit testing and other common tasks

## Usage

Usage of these uitlities is simple.  Inside of of your project's Startus.cs within the RegisterServices method add this line of code.

```
services.UseIcgAspNetCoreUtilities();
```

## Included Features

| Object | Purpose
|----|---|---
| ITimeProvider | Provides a shim around the System.DateTime object to allow for unit testing of date operations|
| IUrlSlugGenerator | Provides a service that will take input and generate a url friendly slug from the content |

Detailed information can be found in the XML Comment documentation for the objects, we are working to add to this document as well.
