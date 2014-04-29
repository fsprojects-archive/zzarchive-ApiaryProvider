#if INTERACTIVE
#load "SetupTesting.fsx"
SetupTesting.generateSetupScript __SOURCE_DIRECTORY__ "ApiaryProvider.DesignTime"
#load "__setup__ApiaryProvider.DesignTime__.fsx"
#else
module internal Test
#endif

open System
open System.IO
open System.Net
open ApiaryProvider.ProviderImplementation

let (++) a b = Path.Combine(a, b)
let resolutionFolder = ""
let outputFolder = __SOURCE_DIRECTORY__ ++ ".." ++ "tests" ++ "ApiaryProvider.DesignTime.Tests" ++ "expected"
let assemblyName = "ApiaryProvider.dll"

type Platform = Net40 | Portable47

let dump signatureOnly ignoreOutput platform saveToFileSystem (inst:TypeProviderInstantiation) =
    let runtimeAssembly = 
        match platform with
        | Net40 -> __SOURCE_DIRECTORY__ ++ ".." ++ "bin" ++ assemblyName
        | Portable47 -> __SOURCE_DIRECTORY__ ++ ".." ++ "bin" ++ "portable47" ++ assemblyName    
    inst.Dump resolutionFolder (if saveToFileSystem then outputFolder else "") runtimeAssembly signatureOnly ignoreOutput
    |> Console.WriteLine

let dumpAll inst = 
    dump false false Net40 false inst
    dump false false Portable47 false inst

Apiary { ApiName = "themoviedb" }
|> dumpAll

let testCases = 
    __SOURCE_DIRECTORY__ ++ ".." ++ "tests" ++ "ApiaryProvider.DesignTime.Tests" ++ "SignatureTestCases.config"
    |> File.ReadAllLines
    |> Array.map TypeProviderInstantiation.Parse

for testCase in testCases do
    dump false false Net40 true testCase
