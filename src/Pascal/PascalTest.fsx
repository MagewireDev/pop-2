#load "Pascal.fs"

open Pascal

let test P = fun x -> if P x then Ok x else Error x

let hasPropertyOne (n: int, k: int) =
    if n < 0 || k < 0 || k > n then
        true // vacuously true for invalid parameters
    elif k = 0 || k = n then
        pascal (n,k) = 1
    else
        true

let testPropertyOne = List.map (test hasPropertyOne)

let hasPropertyTwo (n: int, k: int) =
    if k>0 && k < n then
        pascal (n, k) = pascal (n-1, k-1) + pascal (n-1, k)
    else
        true

let testPropertyTwo = List.map (test hasPropertyTwo)

let testInputs = [
    (-2,-2); (0,-2); (1,-2); (5,-2);
    (-2,0); (0,0); (1,0); (5,0);
    (-2,1); (0,1); (1,1); (5,1);
    (-2,5); (0,5); (1,5); (5,5)
]

let testPropertyOneResults () = testPropertyOne testInputs

let printTestResults results =
    results
    |> List.iter (function
        | Ok (n,k) -> printfn "PASSED: (%d,%d)" n k
        | Error (n,k) -> printfn "FAILED: (%d,%d)" n k
    )

let testPropertyTwoResults () = testPropertyTwo testInputs

printf "Property 1: "
testPropertyOneResults () |> printTestResults
printf "Property 2: "
testPropertyTwoResults () |> printTestResults
