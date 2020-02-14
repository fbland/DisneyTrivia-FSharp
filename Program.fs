// Disney Trivia Game asks player their name
printfn "Hello Player! What is your name?"
let nameString = System.Console.ReadLine()
let name = nameString

if name = nameString
then printfn "Hello %s! Do you have your mouse ears on? Because it's time to play, Do You Know Your Disney?" name

//Disney Trivia Game asks player what level they want to play
//It represents the level of difficulty from 1 to 5, with 5 being the hardest.
printfn "Please enter the level you want to play, from levels 1 to 5. "
let levelString = System.Console.ReadLine()
let level = System.Int32.Parse(levelString)


//Disney Trivia Questions and their answers
if level = 1
then printfn "Level %d: Disney Junior" level
printfn "Level %d: Who is the loving companion of Walt Disney's beloved mouse?" level

//All of the questions are short answer so the user has to input his/her answer
let character1 = System.Console.ReadLine()

if (character1 = "Minnie Mouse") then
    // This is an example of the correct answer.
    printfn "You have now reached the level of a Disney Beholder. Keep up the good work!"
elif (character1 = "Mickey Mouse") then
    // This is an example of an almost correct answer
    printfn "Oh no! You were close but not quite ready for the next level."
else
    // This is an example of an incorrect answer.
    printfn "Sorry! You have not passed the current level but give it another go and you will be on top soon!"

if level = 2
then printfn "Level %d: Disney Beholder" level
printfn "Level %d: Which Disney Prince does not technically exist?" level

let character2 = System.Console.ReadLine()

if (character2 = "Prince Charming") then
    // This is an example of the correct answer.
    printfn "You have now reached the level of a Disney Genius. Keep up the good work!"
elif (character2 = "Prince Ali") then
    // This is an example of an almost correct answer
    printfn "Oh no! You were close but not quite ready for the next level."
else
    // This is an example of an incorrect answer.
    printfn "Sorry! You have not passed the current level but give it another go and you will be on top soon!"

//During the third level, fourth level, and fifth level the user has to answer more questions. 
if level = 3
then printfn "Level %d: Disney Genius" level
printfn "Level %d: Who is the youngest disney princess?" level

let character3 = System.Console.ReadLine()

if (character3 = "Snow White") then
    // This is an example of the correct answer.
    printfn "You are almost to the next level. Excellent!"
elif (character3 = "Rapunzel") then
    // This is an example of an almost correct answer
    printfn "Oh no! You were close but not quite ready for the next level."
    
    printfn "Level %d: Which Disney Movie is located in France?" level

    let character4 = System.Console.ReadLine()

    if (character4 = "Beauty and the Beast") then
        // This is an example of the correct answer.
        printfn "You have now reached the level of a Disney Lover. Spectacular!"
    elif (character4 = "Sleeping Beauty") then
        // This is an example of an almost correct answer
        printfn "Oh no! You were close but not quite ready for the next level."
    else
        // This is an example of an incorrect answer.
        printfn "Sorry! You have not passed the current level but give it another go and you will be on top soon!"

if level = 4
then printfn "Level %d: Disney Lover" level
printfn "Level %d: Which Disney Princess is allegedly the Mother-in-Law of Cinderella?" level

let character5 = System.Console.ReadLine()

if (character5 = "Ariel") then
    // This is an example of the correct answer.
    printfn "You are almost to the next level. You are doing great!"
elif (character5 = "Snow White") then
    // This is an example of an almost correct answer
    printfn "Oh no! You were close but not quite ready for the next level."
else

    printfn "Level %d: Which Disney Channel Character is actually almost on the level of a Disney Princess?" level

    let character6 = System.Console.ReadLine()

    if (character6 = "Kim Possible") then
        // This is an example of the correct answer.
        printfn "You have now reached the highest level, you are a Disney Historian. Spectacular!"
    elif (character6 = "Princess Mia") then
        // This is an example of an almost correct answer
        printfn "Oh no! You were close but not quite ready for the next level."
    else
        // This is an example of an incorrect answer.
        printfn "Sorry! You have not passed the current level but give it another go and you will be on top soon!"

if level = 5
then printfn "Level %d: Disney Historian" level
printfn "Level %d: Which Disney Princess' mother alledgedly appears in the movie Peter Pan?" level

let character7 = System.Console.ReadLine()

if (character7 = "Ariel") then
    // This is an example of the correct answer.
    printfn "You are on your way to surpassing the highest level. Wonderful!"
elif (character7 = "Cinderella") then
    // This is an example of an almost correct answer
    printfn "Oh no! You were close but not quite ready for the next level."
else

    printfn "Level %d: Which Disney Prince has his own movie and grew up facing hardships?" level

    let character8 = System.Console.ReadLine()

    if (character8 = "Prince Ali") then
        // This is an example of the correct answer.
        printfn "You have now surpassed the highest level. Congratulations, you should be placed in Disney Royalty!"
    elif (character8 = "Prince Eric") then
        // This is an example of an almost correct answer
        printfn "Oh no! You were close but not quite ready to have the highest score."
    else
        // This is an example of an incorrect answer.
        printfn "Sorry! You have not surpassed the current level but give it another go and you will be on top soon!"