module CUI
open System
open Spectre.Console

let h1 (str:string) = 
    let figlet = FigletText(str)
    figlet.Color <- Color.Green
    AnsiConsole.Write(figlet)

let h2 (str:string) = 
    let styledStr = Markup($"[yellow]{str}[/]")
    let panel = Panel(styledStr)
    panel.BorderStyle <- Style.Parse("yellow")
    AnsiConsole.Write(panel)

let h3 (str:string) = 
    let cyan = "\u001b[36m"
    let reset = "\u001b[0m"
    Console.WriteLine(cyan + "=== "+ str + reset)