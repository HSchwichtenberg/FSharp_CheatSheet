module Mengen

let run  =
 CUI.h1 "Mengen"

 // ---------------------------------------
 CUI.h2 "Array"
 let array = [|1; 2; 3; 4; 5|] // Array: [|1; 2; 3; 4; 5|]
 printfn "Array: %A" array
 printfn "3. Element im Array: %A" array[2] // 3. Element im Array: 3
 printfn "2. bis 4. Element im Array: %A" array[1..3] // 2. bis 4. Element im Array:
 array[2] <- 42 // erlaubt 
 // arr[6] <- 6 // Index was outside the bounds of the array.
 let neueArray1 = Array.append array [|6|]
 printfn "Neues Array: %A" neueArray1 // Neues Array: [|1; 2; 42; 4; 5; 6|]
 let neueArray2 = Array.removeAt(2) neueArray1
 printfn "Neues Array: %A" neueArray2 // Neues Array: [|1; 2; 4; 5; 6|]

 // ---------------------------------------
 CUI.h2 "List (Immutable)"
 let list = [1; 2; 3; 4; 5]
 printfn "List: %A" list // List: [1; 2; 3; 4; 5]
 printfn "3. Element in List: %A" list[2] // 3. Element in List: 3
 // list[2] <- 4 nicht erlaubt
 // let neuesSet = list.Add(6) nicht erlaubt

 // ---------------------------------------
 CUI.h2 "Set (Immutable)"
 let set = Set.ofList [1; 2; 3; 4; 5]
 printfn "Set: %A" set // Set: set [1; 2; 3; 4; 5]
 // printfn "3. Element in Set: %A" set.toList [2] // nicht erlaubt
 let neuesSet = set.Add(6)
 printfn "Neues Set: %A" neuesSet // Set: set [1; 2; 3; 4; 5; 6]

  // ---------------------------------------
 CUI.h2 "Map (Immutable)"
 let map = Map.ofList [(1, "Eins"); (2, "Zwei"); (3, "Drei")]
 printfn "Map: %A" map // Map: map [(1, "Eins"); (2, "Zwei"); (3, "Drei")]
 printfn "Map: %s" map[2] // Zwei
 // map[2] <- 4 nicht erlaubt

 // TODO: seq