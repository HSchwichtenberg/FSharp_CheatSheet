// For more information see https://aka.ms/fsharp-console-apps
open System

System.Console.Title <- "F# Cheat Sheet"

printfn "F# Cheat Sheet / %s" System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription

printfn "----------------------------------\n"

Basiskonstrukte.start
Operatoren.start
Bedingungen.start
Schleifen.start
Funktionen.start
Fehlerbehandlung.start
Datenstrukturen.start
Mengen.start
KlassenClient.start
Strukturen.start
Computations.start
LINQ.start

// Status
// 28.5.2024: Holger: Erste Version
// 29.5.2024: Holger: Mengen und Tupel ergänzt. Ball jetzt erstmal bei Oliver