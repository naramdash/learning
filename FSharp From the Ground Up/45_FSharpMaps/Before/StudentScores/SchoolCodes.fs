namespace StudentScores

module SchoolCodes =

    open System.IO
    open System.Collections.Generic

    // ## F# Dictionary
    // `dict`
    // Elements, Immutable

    // ## F# Map
    // `Map.ofSeq`
    // Elements, immutable but easy to `copy` with new or removedd elements
    // has interface of IDictionary

    // ## .NET Dictionary
    // `new Dictionary<_, _> (...)`
    // Elements, mutable

    let load (filePath: string) =
        // let pairs =
        //     File.ReadAllLines filePath
        //     |> Seq.skip 1
        //     |> Seq.map (fun row ->
        //             let elements = row.Split('\t')
        //             let id = elements.[0] |> int
        //             let name = elements.[1]
        //             KeyValuePair.Create(id, name))
        // new Dictionary<int, string>(pairs)
        File.ReadAllLines filePath
        |> Seq.skip 1
        |> Seq.map
            (fun row ->
                let elements = row.Split('\t')
                let id = elements.[0] |> int
                let name = elements.[1]
                id, name)
        |> Map.ofSeq
        |> Map.add 0 "(External)"
// Or better still:
//|> readOnlyDict
