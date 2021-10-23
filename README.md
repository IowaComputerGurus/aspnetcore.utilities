# aspnetcore.utilities ![](https://img.shields.io/github/license/iowacomputergurus/aspnetcore.utilities.svg)

![Build Status](https://github.com/IowaComputerGurus/aspnetcore.utilities/actions/workflows/ci-build.yml/badge.svg)

![](https://img.shields.io/nuget/v/icg.aspnetcore.utilities.svg) ![](https://img.shields.io/nuget/dt/icg.aspnetcore.utilities.svg)


A collection of helpful utilities for working with ASP.NET Core projects.  These items are common rules, tag helpers and similar that our team has found valuable.

## Breaking Change with 5.1

A number of elements have been moved to the sister netcore project.

## Usage

### Installation

Install from NuGet

```
Install-Package ICG.AspNetCore.Utilities
```

### Register Dependencies

To utilize the tag helpers modify `_viewimports.cshtml` by adding

```
@addTagHelper *, AspNetCore.Utilities
```

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
