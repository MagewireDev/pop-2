module MyListExamples
open MyList

let input1 = Something (1, Something (2, Something (3, Empty)))
let input2 = Something ("a", Something ("b", Something ("c", Something ("d", Empty))))

let input3 = Empty

// Examples for "take"
printfn "take 2 input1 -> %A" (take 2 input1)
printfn "take 2 input2 -> %A" (take 2 input2)
printfn "take 2 input3 -> %A" (take 2 input3)
printfn "take -2 input1 -> %A" (take -2 input1)

// Examples for "drop"
printfn "drop 2 input1 -> %A" (drop 2 input1)
printfn "drop 2 input2 -> %A" (drop 2 input2)
printfn "drop 2 input3 -> %A" (drop 2 input3)
printfn "drop -1 input1 -> %A" (drop -2 input1) // returns full list!

// Examples for "length"
printfn "length input1 -> %A" (length input1)
printfn "length input2 -> %A" (length input2)
printfn "length input3 -> %A" (length input3)

// Examples for "map"
printfn "map (fun x -> x + x) input1 -> %A" (map (fun x -> x + x) input1)
printfn "map (fun x -> x + x) input1 -> %A" (map (fun x -> x + x) input2)
printfn "map (fun x -> x + x) input1 -> %A" (map (fun x -> x + x) input3)