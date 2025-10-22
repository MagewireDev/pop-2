module MyList
type 'a MyList = 
    | Empty 
    | Something of 'a * 'a MyList

let rec take n list =
    match n, list with
    | n, _ when n <= 0 -> Empty
    | _, Empty -> Empty
    | n, Something (head, tail) -> Something (head, take (n - 1) tail)

let rec drop n list =
    match n, list with
    | n, _ when n <= 0 -> list
    | _, Empty -> Empty
    | n, Something (_, tail) -> drop (n-1) tail

let rec length list = 
    match list with
    | Empty -> 0
    | Something (_, tail) -> 1 + length tail

let rec map f list =
    match list with
    | Empty -> Empty
    | Something (head, tail) -> Something (f head, map f tail)

