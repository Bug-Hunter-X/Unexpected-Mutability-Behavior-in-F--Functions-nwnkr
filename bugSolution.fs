let x = ref 10
let y = ref 20

let add x y = !x + !y

let z = add x y

printf "%d\n" z //This will print 30

x := 15
y := 25

let z2 = add x y
printf "%d\n" z2 //This will print 40

//The solution uses references to track values. The add function is unchanged, but the way values are passed and assigned is different. When x and y are updated using ':=' the updated values are reflected in further calls to the add function.