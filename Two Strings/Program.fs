(*
    Given two strings, determine if they share a common substring.
    A substring may be as small as one character. 
*)

let testCases = System.Console.ReadLine() |> int

let hasCommonSubstring (s1: string) (s2: string) =
    let firstSet = s1 |> Set.ofSeq
    if Seq.exists firstSet.Contains s2 then "YES" else "NO"

Seq.init (2 * testCases) (fun _ -> System.Console.ReadLine())
|> Seq.chunkBySize 2
|> Seq.take testCases
|> Seq.map (fun chunk -> hasCommonSubstring chunk.[0] chunk.[1])
|> Seq.iter (printfn "%s")
