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
let hasPropertyOneNoRec (n: int, k: int) =
    if n < 0 || k < 0 || k > n then
        true
    elif k = 0 || k = n then
        pascalNoRec (n,k) = 1
    else
        true
let hasPropertyTwo (n: int, k: int) =
    if k>0 && k < n then
        pascal (n, k) = pascal (n-1, k-1) + pascal (n-1, k)
    else
        true

let hasPropertyTwoNoRec (n: int, k: int) =
    if k>0 && k < n then
        pascalNoRec (n, k) = pascalNoRec (n-1, k-1) + pascalNoRec (n-1, k)
    else
        true

let testPropertyOne = List.map (test hasPropertyOne)

let testPropertyOneNoRec = List.map (test hasPropertyOneNoRec)

let testPropertyTwo = List.map (test hasPropertyTwo)

let testPropertyTwoNoRec = List.map (test hasPropertyTwoNoRec)

let testInputs = [
    (-2,-2); (0,-2); (1,-2); (5,-2);
    (-2,0); (0,0); (1,0); (5,0);
    (-2,1); (0,1); (1,1); (5,1);
    (-2,5); (0,5); (1,5); (5,5)
]


let testPropertyOneResults () = testPropertyOne testInputs

let testPropertyOneNoRecResults () = testPropertyOneNoRec testInputs

let testPropertyTwoResults () = testPropertyTwo testInputs

let testPropertyTwoNoRecResults () = testPropertyTwoNoRec testInputs

let printTestResults results =
    results
    |> List.iter (function
        | Ok (n,k) -> printfn "PASSED: (%d,%d) -> %d" n k (pascal (n, k))
        | Error (n,k) -> printfn "FAILED: (%d,%d) -> %d" n k (pascal (n, k))
    )

let printTestResultsNoRec results =
    results
    |> List.iter (function
        | Ok (n,k) -> printfn "PASSED: (%d,%d) -> %d" n k (pascalNoRec (n, k))
        | Error (n,k) -> printfn "FAILED: (%d,%d) -> %d" n k (pascalNoRec (n, k))
    )

printf "RECURSION: \n"
printf "Property 1: \n"
testPropertyOneResults () |> printTestResults
printf "Property 2: "
testPropertyTwoResults () |> printTestResults

printf "NO RECURSION: \n"
printf "Property 1: \n"
testPropertyOneNoRecResults () |> printTestResultsNoRec
printf "Property 2: "
testPropertyTwoNoRecResults () |> printTestResultsNoRec
