
// NOTE: If warnings appear, you may need to retarget this project to .NET 4.0. Show the Solution
// Pad, right-click on the project node, choose 'Options --> Build --> General' and change the target
// framework to .NET 4.0 or .NET 4.5.

module CsvTypeProviderSample.Main

open System
open FSharp.Data

type CodeSample = CsvProvider<"../App_Data/CodeSample.csv">

let someFunction x y = x + y

[<EntryPoint>]
let main args = 
    
    let sample = CodeSample.Load("../../../App_Data/CodeSample.csv")
    sample.Data
    |> Seq.iter (fun x -> printfn "%s %s" x.Name x.Title)
    
    0

