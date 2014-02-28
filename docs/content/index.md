Apiary Provider
================================

The Apiary Provider library (`ApiaryProvider.dll`) contains a type provider for calling REST APIs based on the 
[apiary.io](http://apiary.io) service. If you host a documentation for your REST API
at apiary and your REST API follows standard patterns, you can easily call it using
the type provider.

### Library license

The library is available under Apache 2.0. For more information see the 
[License file][license] in the GitHub repository. In summary, this means that you can 
use the library for commercial purposes, fork it, and modify it as you wish.

<br/><hr/>

# How to get ApiaryProvider

* The Apiary Provider Library is available as <a href="https://nuget.org/packages/ApiaryProvider">ApiaryProvider on NuGet</a>.

* In addition to the official releases, you can also get NuGet packages from the [Continuous Integration package source](https://ci.appveyor.com/nuget/apiaryprovider-aq55sqnm25bh).

* Alternatively, you can download the [source as a ZIP file][source] or download the [compiled binaries][compiled] as a ZIP. <br /> Please note that on windows when downloading a zip file with `dll` files the files will be blocked, and you have to manually unblock them in the file properties.

<br/><hr/>

# Using Apiary Provider

### F# type providers

The library currently contains a type provider for calling REST APIs based on the 
[apiary.io](http://apiary.io) service. If you host a documentation for your REST API
at apiary and your REST API follows standard patterns, you can easily call it using
the type provider.

 * [Apiary Provider: Apiary Provider](library/ApiaryProvider.html) - discusses 
   the `ApiaryProvider` type. 

### Reference Documentation

There's also [reference documentation](reference) available. Please note that everything under the `ApiaryProvider.Runtime` namespace is not considered as part of the public API and can change without notice.

<br/><hr/>

# Contributing

Apiary Provider is made possible by the volunteer work [of several contributors](https://github.com/fsprojects/ApiaryProvider/graphs/contributors) and we're open to contributions from anyone. If you want to help out but don't know where to start, you can take one of the [Up-For-Grabs](https://github.com/fsprojects/ApiaryProvider/issues?labels=up-for-grabs&state=open) issues, or help to improve the documentation.

The project is hosted on [GitHub][gh] where you can [report issues][issues], fork 
the project and submit pull requests. If you're adding new public API's, please also 
contribute [samples][samples] that can be turned into a documentation.

 * If you want to discuss an issue or feature that you want to add the to the library,
   then you can submit [an issue or feature request][issues] via Github or you can 
   send an email to the [F# open source][fsharp-oss] mailing list.

 * For more information about the library architecture, organization, how to debug, etc., see the [contributing to Apiary Provider](contributing.html) page.

  [source]: https://github.com/fsprojects/ApiaryProvider/zipball/master
  [compiled]: https://github.com/fsprojects/ApiaryProvider/zipball/release
  [samples]: https://github.com/fsprojects/ApiaryProvider/tree/master/docs/content
  [gh]: https://github.com/fsprojects/ApiaryProvider
  [issues]: https://github.com/fsprojects/ApiaryProvider/issues
  [license]: https://github.com/fsprojects/ApiaryProvider/blob/master/LICENSE.md
  [fsharp-oss]: http://groups.google.com/group/fsharp-opensource
