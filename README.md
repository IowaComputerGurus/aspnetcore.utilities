# aspnetcore.utilities ![](https://img.shields.io/github/license/iowacomputergurus/aspnetcore.utilities.svg)
| Master | Develop |
| --- | --- |
| ![Master Branch Status](https://iowacomputergurus.visualstudio.com/ICG%20Open%20Source/_apis/build/status/AspNetCore%20Utilities?branchName=master) | ![Development Branch Status](https://iowacomputergurus.visualstudio.com/ICG%20Open%20Source/_apis/build/status/AspNetCore%20Utilities?branchName=development) |

## NuGet Package Information
ICG.AspNetCore.Utilities ![](https://img.shields.io/nuget/v/icg.aspnetcore.utilities.svg) ![](https://img.shields.io/nuget/dt/icg.aspnetcore.utilities.svg)


A collection of helpful utilities for working with ASP.NET Core projects.  These items are used by the IowaComputerGurus Team to aid in unit testing and other common tasks

## Usage

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

If you desire to use the included Taghelpers inside of your `_viewimports.cshtml` add

```
@addTagHelper *, ICG.AspNetCore.Utilities
```

### Included C# Objects

| Object | Purpose |
| ---- | --- |
} IDirectory Provider | Provides a shim around the System.IO.Directory object to allow for unit testing. |
| IGuidProvider | Provides a shim around the System.Guid object to allow for unit testing of Guid operations.  |
| IFileProvider | Provides a shim around the System.IO.File object to allow for unit testing of file related operations. |
| IPathProvider | Provides a shim around the System.IO.Path object to allow for unit testing of path related operations | 
| ITimeProvider | Provides a shim around the System.DateTime object to allow for unit testing of date operations |
| ITimeSpanProvider | Provides a shim around the System.TimeSpan object to allow for unit testing/injection of TimeSpan operations |
| IUrlSlugGenerator | Provides a service that will take input and generate a url friendly slug from the content |
| ForceNonWwwRewriteRule | An `IRule` implementation that will strip www. from the start of the host name if found |
| ForceWwwRewriteRule | An `IRule` implementation that will force a URL to have www. as a prefix |

Detailed information can be found in the XML Comment documentation for the objects, we are working to add to this document as well.

**Caution:** As expected the use of both ForceNonWwwRewriteRule and ForceWwwRewriteRule in the same installation will result in broken sites.

### Included Tag Helpers

#### HideCondition 
This tag helper will hide the content of the target element if the condition is true, an example.

```
<div hide-condition="Model.Deleted">

</div>
```

#### Show Condition
This tag helper will show the content of the target element if the condition is true, an example.

```
<div show-condition="Model.Published">

</div>
```
