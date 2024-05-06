(*
    Mark and Jane are very happy after having their first child.
    Their son loves toys, so Mark wants to buy some.
    There are a number of different toys lying in front of him,
    tagged with their prices. Mark has only a certain amount to spend,
    and he wants to maximize the number of toys he buys with this money.
    Given a list of toy prices and an amount to spend,
    determine the maximum number of gifts he can buy.

    Note Each toy can be purchased only once. 
*)

let toysCount, availableFunds =
    System.Console.ReadLine().Split(' ')
    |> Seq.map int
    |> Seq.toList
    |> fun x -> x[0], x[1]

let canBuy price = price <= availableFunds

let toyPrices =
    System.Console.ReadLine().Split(' ')
    |> Seq.truncate toysCount
    |> Seq.map int
    |> Seq.filter canBuy
    |> Seq.sort
    |> Seq.toList

let countToys prices funds =
    let rec loop prices total count =
        match prices with
        | price :: rest when total + price <= funds -> loop rest (total + price) (count + 1)
        | _ -> count

    loop prices 0 0

printfn $"%d{countToys toyPrices availableFunds}"
