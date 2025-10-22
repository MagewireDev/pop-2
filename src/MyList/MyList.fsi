module MyList
// A cons list type which is either empty, or a pair of a head element and a tail list
type 'a MyList = 
    | Empty 
    | Something of 'a * 'a MyList

// Takes an integer n and a MyList, and returns a MyList of the first n elements in the original list.
// input n (int) : the number of elements to take from the front of the list
// input list (MyList): a MyList to take elements from
// output (MyList): a new list containing the first n elements of the input list
val take : int -> 'a MyList -> 'a MyList

// Takes an integer n and a MyList, and returns a MyList without the first n elements of the original list.
// input n (int) : the number of elements to drop from the beginning of the list
// input list (MyList) : a MyList to drop elements from
// output (MyList) : a new list without the first n elements of the input list
val drop : int -> 'a MyList -> 'a MyList

// Takes a MyList and returns the number of elements in the list.
// input list (MyList) : a MyList to calculate the length of
// output (int) : the number of elements in the input list
val length : 'a MyList -> int

// Takes a function, and a MyList and returns a MyList with the function applied to each element.
// input f (function) : a function to apply to each element in the input list
// input list (MyList) : a MyList with elements to apply a function to
// output (MyList) : a MyList where each element is the output of the input function applied to each element in the input list
val map : ('a -> 'b) -> 'a MyList -> 'b MyList