module Basiskonstrukte
open System

let start  =
 // ---------------------------------------
 CUI.h1 "Variablen und Konstanten"

 let a = 42 // unveränderbare Variable (Zahl)
 // a <- a+ 1 // nicht möglich

 let b = "Oliver Sturm" // unveränderbare Variable (Zeichenkette)

 let mutable c = "Holger Schwichtenberg"  // veränderbare Variable
 c <- "Dr. " + c

 // ---------------------------------------
 CUI.h1 "Literale"

 // Zahlen
 let zahl = 42
 let gebrocheneZahl = 42.5 
 let grosseZahl = 42_000_000_000.123 

 // Zeichenketten
 let autor1 = "Oliver\nSturm" // Zeichenkette mit Escape-Sequenz
 let autor2 = """Holger 
Schwichtenberg""" // Zeichenkette mit drei Anführungszeichen und Umbruch
 let pfad = @"C:\temp" // Zeichenkette mit Verbatim-String

 // String-Interpolation
 // Interpolierte Zeichenkette (Template String)
 let ausgabe1 = $"{autor1} ist älter als {zahl}."
 // Interpolierte Zeichenkette mit Umbruch
 let ausgabe2 = $"Autoren:\n{autor1}\nund\n{autor2}"
   // Interpolierte Zeichenkette mit drei Anführungszeichen und Umbruch
 let ausgabe3 = $"""Autoren: 
{autor1}
und
{autor2}"""
 // Interpolierte Zeichenkette mit drei Anführungszeichen und Ausdruck
 let ausgabe4 = $"""Die Zahl {a} ist eine {if a % 2 = 0 then "gerade" else "ungerade"} Zahl."""

 // Boolean
 let bool = true

 // Regex
 let regEx = System.Text.RegularExpressions.Regex("a[0-9]")

 // Datum
 let datum = System.DateTime(2024, 7, 15)

 // Nullable
 let mutable nullableZahl = Nullable(42) // Nullable Ganzzahl
  
 // ---------------------------------------
 CUI.h1 "Bildschirmausgaben"
 printf "verschiedene Möglichkeiten " // Ausgabe ohne Umbruch
 printfn "für Bildschirmausgaben" // Ausgabe mit Umbruch

 printfn "Ganzzahl: %d" zahl // Ganzzahl: 42
 printfn "Hexadezimalzahl: %x" zahl // Hexadezimalzahl: 2a
 printfn "Oktalzahl: %o" zahl // Oktalzahl: 52
 printfn "Binärzahl: %B" zahl // Binärzahl: 101010
 printfn "Gleitkommatyp: %e" gebrocheneZahl // Ausgabe ohne Umbruch
 printfn "Zeichenkette: %s" pfad // Zeichenkette: C:\Temp
 printfn "Bool: %b" bool // Bool: true
 printfn "Datum: %O" datum // Datum: 15.07.2024 00:00:00
 printfn "RegEx: %O" regEx // RegEx:a[0-9]

 printfn "Zahl oder null: %A" nullableZahl // Zahl oder null: 42
 nullableZahl <- Nullable() // null zuweisen geht nicht mit null!
 printfn "Zahl oder null: %A" nullableZahl // Zahl oder null: <null>
 Console.WriteLine("null an Methode übergeben: {0}", null);

 // Ausgabe mehrerer Werte
 printfn "%s ist älter als %d" b a // Oliver Sturm ist älter als 42
 // Ausgabe mit .NET-Klasse System.Console
 Console.WriteLine(b + " ist älter als  " + a.ToString() + ".") // Oliver Sturm ist älter als 42

 // Ausgabe von interpolierten Zeichenketten (NUR ZUR KONTROLLE)
 printfn "%s" ausgabe1 // Oliver Sturm ist älter als 42
 printfn "%s" ausgabe2 // Autoren:\nOliver Sturm\nund\nDr. Holger Schwichtenberg
 printfn "%s" ausgabe3 // Autoren:\nOliver Sturm\nund\nDr. Holger Schwichtenberg
 printfn "%s" ausgabe4 // Die Zahl 42 ist eine gerade Zahl.