﻿module DoYouKnowDisney =
/// Represents one of the potential Disney Characters as answer
type Character =
| Mickey
| Minnie
| PrinceAli
| PrinceCharming
| SnowWhite
| Aurora
| Ariel

/// Represents the difficulty of each Character's Question
type Rank =
/// Represents the rank from being easiest to hardest
| Value of int
| Minnie
| Mickey
| Aurora
| PrinceCharming
| SnowWhite
| Ariel
| PrinceAli

//Represents the level of difficulty for each Character's Question from 1 to 10
let Minnie = 1
let Mickey = 2
let Aurora = 4
let PrinceCharming = 6
let SnowWhite = 7
let Ariel = 9
let PrinceAli = 10


let disneyTrivia101 answer guess =
    if guess = answer then
       System.Console.WriteLine("You are a Disney Expert!!!")
    else
       System.Console.WriteLine("Looks like you are not a Disney Expert after all. Try again.")

let disneyQuiz = disneyTrivia101 "Minnie"
// I sent in my guesses.
disneyQuiz "PrinceCharming"  
disneyQuiz "Ariel"
disneyQuiz "Minnie"

let disneyExpert = disneyTrivia101 "Mickey"
disneyExpert "PrinceAli"  
disneyExpert "Mickey"
disneyExpert "SnowWhite"

let disneyGenius = disneyTrivia101 "Aurora"
disneyGenius "Aurora"
disneyGenius "Minnie"
disneyGenius "Aurora"

let disneyLover = disneyTrivia101 "PrinceCharming"
disneyGenius "PrinceCharming"
disneyGenius "PrinceCharming"
disneyGenius "PrinceAli"

let disneyHistorian = disneyTrivia101 "SnowWhite"
disneyGenius "Minnie"
disneyGenius "Mickey"
disneyGenius "Aurora"