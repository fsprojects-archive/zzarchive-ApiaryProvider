namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ApiaryProvider")>]
[<assembly: AssemblyProductAttribute("ApiaryProvider")>]
[<assembly: AssemblyDescriptionAttribute("Type provider for Apiary.io")>]
[<assembly: AssemblyVersionAttribute("1.0.1.47")>]
[<assembly: AssemblyFileVersionAttribute("1.0.1.47")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.1.47"
