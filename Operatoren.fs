module Operatoren
open System
open Spectre.Console

let run =
 CUI.h1 "Operatoren"

 printfn "%d" (1 + 2)  // 3
 printfn "%d" (1 - 2)  // -1
 printfn "%d" (1 * 2)  // 2
 printfn "%f" (1.0 / 2.0)  // 0.5
 printfn "%d" (1 % 2)  // 1 (Modulus)
 printfn "%d" (pown 2 3)  // 8 (Exponentiation)
 printfn "%b" (1 > 2)  // false
 printfn "%b" (1 < 2)  // true
 printfn "%b" (1 >= 2)  // false
 printfn "%b" (1 <= 2)  // true
 printfn "%b" (1 = 2)  // false (gleich)
 printfn "%b" (1 <> 2)  // true (ungleich)
 printfn "%d" (if 1 <> 0 then 42 else 43) // 42 (ternärer Operator)
 printfn "%d" (if 1=1 && 2=2 then 42 else 43) // 42 (logisches Und)
 printfn "%d" (if 1=2 || 2=2 then 42 else 43) // 42 (logisches Oder)
 printfn "%b" (not (1 <> 0))  // false (logisches Nicht)
 printfn "%d" (1 &&& 2)  // 0 (bitweises Und)
 printfn "%d" (1 ||| 2)  // 3 (bitweises Oder)
 printfn "%d" (1 ^^^ 2)  // 3 (bitweises Exklusiv-Oder)
 printfn "%d" (~~~1)  // -2 (bitweises Nicht)
 printfn "%d" (1 <<< 2)  // 4 (bitweises Linksverschieben)
 printfn "%d" (1 >>> 2)  // 0 (bitweises Rechtsverschieben mit Vorzeichen)

 let koennteNoneSein = None
 printfn "%s" (defaultArg koennteNoneSein "Standardwert")  // Standardwert

 CUI.h1 "Zeichenketten-Operatoren"

 let a = "Holger Schwichtenberg";
 let b = "Dr. " + a // Verkettung
 printfn "%s" b  // Dr Holger Schwichtenberg

 let c = b[0] // Nur das erste Zeichen via Index
 printfn "%c" c  // D

 let d = b[4..9] // Zeichen 5 bis 8 via Slicing
 printfn "%s" d  // Holger

