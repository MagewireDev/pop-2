module MyList
// A cons list type which is either empty, or a pair of a head element and a tail list
type 'a MyList = 
    | Empty 
    | Something of 'a * 'a MyList

// Takes an integer n and a MyList, and returns a MyList of the first n elements in the original list.
val take : int -> 'a MyList -> 'a MyList

// Takes an integer n and a MyList, and returns a MyList without the first n elements of the original list.
val drop : int -> 'a MyList -> 'a MyList

// Takes a MyList and returns the number of elements in the list.
val length : 'a MyList -> int

// Takes a function, and a MyList and returns a MyList with the function applied to each element.
val map : ('a -> 'b) -> 'a MyList -> 'b MyList