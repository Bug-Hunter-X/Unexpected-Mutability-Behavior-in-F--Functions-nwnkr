let mutable x = 10
let mutable y = 20

let add x y = x + y

let mutable z = add x y

printf "%d\n" z //This will print 30

x <- 15
y <- 25

printf "%d\n" z //This will still print 30, not 40 as one might expect. 

//The reason for this is that z is not a reference to the function add, but rather a copy of the result of the add function when it was called. Thus, changes to x and y after the initial assignment of z have no effect on z. 