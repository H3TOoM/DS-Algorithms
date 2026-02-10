

// Stack ==> LIFO Data Structure (Last In, First Out)
Stack<string> videoGamesStack = new Stack<string>();
videoGamesStack.Push("The Legend of Zelda: Breath of the Wild");
videoGamesStack.Push("Super Mario Odyssey");
videoGamesStack.Push("Animal Crossing: New Horizons");
Console.WriteLine(videoGamesStack.Peek()); // Outputs "Animal Crossing: New Horizons" without removing it from the stack
Console.WriteLine("-----------------------------------");

String myFavoriteGame = videoGamesStack.Pop(); // Removes "Animal Crossing: New Horizons" from the stack
Console.WriteLine($"My favorite game is: {myFavoriteGame}");
Console.WriteLine("-----------------------------------");


foreach (var item in videoGamesStack)
    Console.WriteLine(item);


Console.WriteLine("-----------------------------------");
// Search for a specific game in the stack
string gameToFind = "Super Mario Odyssey";
if (videoGamesStack.Contains(gameToFind))
    Console.WriteLine($"{gameToFind} is in the stack.");
else
    Console.WriteLine($"{gameToFind} is not in the stack.");


// Uses of Stack
// 1. Undo functionality in applications
// 2. Backtracking algorithms (e.g., maze solving, depth-first search)
// 3. Expression evaluation (e.g., converting infix to postfix notation)
// 4. Function call management in programming languages (call stack)
