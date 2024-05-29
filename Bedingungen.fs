module Bedingungen

open System

let start  =
 CUI.h1 "Bedingungen"

 // ---------------------------------------
 CUI.h2 "if" 
 let random = Random()
 let z1 = random.Next(1, 11)  // Generiert eine Zufallszahl zwischen 1 und 10

 if z1 > 5 then
     printfn "Die Zahl %d ist größer als 5" z1
 elif z1 = 5 then
     printfn "Die Zahl ist gleich 5"
 else
     printfn "Die Zahl %d ist kleiner als 5" z1

 // ---------------------------------------
 CUI.h2 "match"
 match z1 with
 | 1 -> printfn "Die Zahl ist 1"
 | 2 -> printfn "Die Zahl ist 2"
 | 3 -> printfn "Die Zahl ist 3"
 | _ -> printfn "Die Zahl %d ist größer als 3" z1

 // TODO: Pattern Matching
