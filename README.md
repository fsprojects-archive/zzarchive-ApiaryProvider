[![Issue Stats](http://issuestats.com/github/fsprojects/ApiaryProvider/badge/issue)](http://issuestats.com/github/fsprojects/ApiaryProvider)
[![Issue Stats](http://issuestats.com/github/fsprojects/ApiaryProvider/badge/pr)](http://issuestats.com/github/fsprojects/ApiaryProvider)

# ApiaryProvider

A type provider for Apiary.io [![NuGet Status](http://img.shields.io/nuget/v/ApiaryProvider.svg?style=flat)](https://www.nuget.org/packages/ApiaryProvider/)

You can see the version history [here](RELEASE_NOTES.md).

## Building

- Simply build ApiaryProvider.sln in Visual Studio, Mono Develop, or Xamarin Studio. You can also use the FAKE script:

  * Windows: Run *build.cmd* 
    * [![AppVeyor build status](https://ci.appveyor.com/api/projects/status/x0ads3t2s6f9cand)](https://ci.appveyor.com/project/ovatsus/apiaryprovider)
  * Mono: Run *build.sh*
    * [![Travis build status](https://travis-ci.org/fsprojects/ApiaryProvider.png)](https://travis-ci.org/fsprojects/ApiaryProvider)

## Supported platforms

- VS2012 compiling to FSharp.Core 4.3.0.0
- VS2012 compiling to FSharp.Core 2.3.5.0 (PCL profile 47)
- Mono F# 3.0 compiling to FSharp.Core 4.3.0.0
- Mono F# 3.0 compiling to FSharp.Core 2.3.5.0 (PCL profile 47)
- VS2013 compiling to FSharp.Core 4.3.0.0
- VS2013 compiling to FSharp.Core 4.3.1.0
- VS2013 compiling to FSharp.Core 2.3.5.0 (PCL profile 47)
- VS2013 compiling to FSharp.Core 2.3.6.0 (PCL profile 47)
- Mono F# 3.1 compiling to FSharp.Core 4.3.0.0
- Mono F# 3.1 compiling to FSharp.Core 4.3.1.0
- Mono F# 3.1 compiling to FSharp.Core 2.3.5.0 (PCL profile 47)
- Mono F# 3.1 compiling to FSharp.Core 2.3.6.0 (PCL profile 47)

## Documentation 

This library is that it comes with comprehensive documentation. The documentation is 
automatically generated from `*.fsx` files in [the content folder][2] and from the comments in the code. If you find a typo, please submit a pull request! 
 - [Apiary Provider home page][3] with more information about the library, contributions, etc.
 - The samples from the documentation are included as part of `ApiaryProvider.Tests.sln`, make sure you build the
solution before trying out the samples to ensure that all needed packages are installed.

## Support and community

 - If you have a question about `ApiaryProvider`, ask at StackOverflow. 
 - If you want to submit a bug, a feature request or help witht fixing bugs then look at [issues](https://github.com/fsprojects/ApiaryProvider/issues) and read [contributing to Apiary Provider](http://fsprojects.github.io/ApiaryProvider/contributing.html).
 - To discuss more general issues about F# Data, its goals and other open-source F# projects, join the [fsharp-opensource mailing list](http://groups.google.com/group/fsharp-opensource)

## Library license

The library is available under Apache 2.0. For more information see the [License file][1] in the GitHub repository.

 [1]: https://github.com/fsprojects/ApiaryProvider/blob/master/LICENSE.md
 [2]: https://github.com/fsprojects/ApiaryProvider/tree/master/docs/content
 [3]: http://fsprojects.github.io/ApiaryProvider/


## Maintainer(s)

- [@ovatsus](https://github.com/ovatsus)

The default maintainer account for projects under "fsprojects" is [@fsgit](https://github.com/fsgit) - F# Community Project Incubation Space (repo management)
