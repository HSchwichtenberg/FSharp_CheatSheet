module Funktionen

let run = 
 CUI.h1 "Funktionen"

 // ---------------------------------------
 CUI.h2 "Funktionen ohne Parameter"
 let f1 = 
   printfn "Hallo, Welt!"
 
 f1

 // ---------------------------------------
 CUI.h2 "Funktionen mit einem Parameter"
 let f2 (name:string) = 
   printfn "Hallo, %s!" name
 
 f2 "Holger"

 // ---------------------------------------
 CUI.h2 "Funktionen mit einem Parameter mit Typinferenz"
 let f3 (name) = 
   printfn "Hallo, %s!" name
 
 f3 "Holger"

 // ---------------------------------------
 CUI.h2 "Funktionen mit mehreren Parametern"
 let f4 (name:string, alter:int) = 
    printfn "%s ist %d Jahre alt." name alter
 
 f4 ("Holger", 51)

 // ---------------------------------------
 CUI.h2 "Funktionen mit Rückgabewert"
 let f5 (name:string, alter:int) = 
   let r = sprintf "%s ist %d Jahre alt" name alter
   r + "." // letzter Ausdruck ist der Rückgabewert

 let text = f5 ("Holger", 51)
 printfn "%s" text  


// TODO: Rekursive Funktionen, Parameter Arrays, Function Values, Lambdas, Pipelines, ...