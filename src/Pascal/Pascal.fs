module Pascal

let rec pascal ((n: int), (k: int)) =
    if n < 0 || k < 0 || k > n then
        0
    else
        match (k, n) with
        | (0, _) -> 1
        | (k, n) when k = n -> 1
        | (k, n) when k > n -> 0
        | (k,n) -> pascal ((n-1), (k-1)) + pascal ((n-1), k)

let pascalNoRec (n: int, k: int) =
    if n < 0 || k < 0 || k > n then
        0
    else
        let mutable triangle : int list list = [[1]]

        for i in 1 .. n do
            let prev = List.last triangle
            let mutable row = [1]
            for j in 1 .. (List.length prev - 1) do
                let value = prev.[j-1] + prev.[j]
                row <- row @ [value]
            
            row <- row @ [1]
            triangle <- triangle @ [row]

        (List.item n triangle).[k]

