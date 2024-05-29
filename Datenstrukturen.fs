module Datenstrukturen

// Eigener Tupel-Typ
type PersonTupel = int * string * string

let run  =
 CUI.h1 "Datenstrukturen"

 // ---------------------------------------
 CUI.h2 "Tupel"
 let tupel1 = (45257, "Essen", "Holger Schwichtenberg") 
 let tupel2: PersonTupel = (45257, "Essen", "Holger Schwichtenberg")

 printfn "Tupel: %A" tupel1
 // Dekonstruktion 
 let (plz, stadt, name) = tupel1
 printfn "Teile des Tupels: %s wohnt in %d %s" name plz stadt 

 // TODO: Generic Types, Enums