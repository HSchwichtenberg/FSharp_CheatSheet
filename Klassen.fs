namespace Klassen

open System

/// Klasse für eine Person
type Person(vorname: string, name: string) as self =
 // Private statische Felder
 static let mutable instanzZaehler = 0
 static let mutable alleInstanzen = ResizeArray<Person>()

 // Private Instanzfelder
 let mutable id = 0
 let mutable Vorname = vorname
 let mutable Name = name

 // Konstruktor
 do
     instanzZaehler <- instanzZaehler + 1
     id <- instanzZaehler
     alleInstanzen.Add(self) // erfordert "as self" in der Klassendefinition
      
 // Öffentliche statisches Mitglied
 static member AlleInstanzen = alleInstanzen

 // Öffentliche Instanz-Eigenschaften mit Getter und Setter
 member this.GanzerName
     with get() = sprintf "%s %s" vorname name
     and set (ganzername: string) =
         let namensTeile = ganzername.Split(' ')
         if namensTeile.Length <> 2 then
             // TODO invalidArg "GanzerName" "Ungültiger Name"
             raise (ArgumentException("Ungültiger Name"))
         Vorname <- namensTeile.[0]
         Name <- namensTeile.[1]

 // Öffentliche Instanz-Methode
 member this.Print =
     printfn "Person #%d: %s" id this.GanzerName

/// Trainer erbt von Person
 type Trainer(vorname: string, name: string, fach: string) =
  inherit Person(vorname, name)
  // Öffentliche Instanz-Éigenschaft
  member this.Fach = fach

  // Öffentliche Instanz-Methode
  member this.Print =
      printfn "Trainer %s unterrichtet %s." this.GanzerName this.Fach
     
   // Öffentliche Instanz-Methode mit optionalen Parametern (Optionale Parameter nur in Methoden, nicht in einfachen Funktionen erlaubt)
  member this.PrintColor(?color1: string, ?color2: string) =
      let color1 = defaultArg color1 "\u001b[32m"
      let color2 = defaultArg color2 "\u001b[33m"
      let reset = "\u001b[0m"
      printfn "Trainer %s%s%s unterrichtet %s%s%s." color1 this.GanzerName reset color2 this.Fach reset

  member this.Berechnen(x:inref<int>, y:outref<int>, z: byref<int> ) = 
     // x <- x + 1 nicht erlaubt, da x inref ist
     y <- x + y
     z <- y + 1


// TODO: Methoden mit optionalen Parametern, Defaultwerte, Parameter Arrays
