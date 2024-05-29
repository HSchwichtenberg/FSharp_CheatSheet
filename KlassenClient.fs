module KlassenClient
open Klassen

let start =
 CUI.h1 "Klassen nutzen"
 // Instanz erzeugen
 let p = Person("Dr. Holger", "Schwichtenberg")
 printfn "%s" p.GanzerName
 // printfn t.id // nicht möglich, da privat!
 p.Print

 let t = Trainer("Oliver", "Sturm", "F#")
 t.GanzerName <- "Oli Sturm"
 printfn "Trainer %s unterrichtet %s." t.GanzerName t.Fach
 // t.Fach <- "C# und F#" // nicht möglich, da kein Setter!
 t.PrintColor("\u001b[32m", "\u001b[33m") // Aufruf mit beiden Parametern
 t.PrintColor() // Aufruf ohne Werte, also mit Standardwerte
 t.PrintColor(color2 = "\u001b[32m") // Aufruf mit einem benannten Parameter
 printfn "Es gibt nun %d Personen." Person.AlleInstanzen.Count // Es gibt nun 2 Personen.

 // Aufrufe von Referenzparametern
 let mutable x = 1;
 let mutable y = 2;
 let mutable z = 0;
 t.Berechnen (&x, &y, &z)
 printfn "Berechnet: x=%d y=%d z=%d" x y z  // x=1 y=3 z=4