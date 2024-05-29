module Schleifen

open System

let start  =
 CUI.h1 "Schleifen"

 // ---------------------------------------
 CUI.h2 "for...do-Schleife vorwärts"
 for i in 1 .. 10 do
     printfn "%d" i

 // ---------------------------------------
 CUI.h2 "for...do-Schleife rückwärts"
 for i in 10 .. -1 .. 1 do
     printfn "%d" i

 // --------------------------------------- 
 CUI.h2 "for..in-Schleife über die Elemente eines Arrays"
 let array = [| 1; 2; 3 |]
 for x in array do
     printfn "%d" x
  
 // ---------------------------------------
 CUI.h2 "for..in-Schleife über ein Dictionary"
 let objektMitWerten = dict ["a", 1; "b", 2; "c", 3]
 for kvp in objektMitWerten do
     printfn "Schlüssel %s = Wert %d" kvp.Key kvp.Value
  
 // ---------------------------------------
 CUI.h2 "while-Schleife (kein do...while, kein break)"
 let mutable i = 1
 while i <= 10 do
     printfn "%d" i
     i <- i + 1