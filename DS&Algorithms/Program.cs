

// Stack ==> LIFO Data Structure (Last In, First Out)
Stack<string> videoGamesStack = new Stack<string>();
videoGamesStack.Push("The Legend of Zelda: Breath of the Wild");
videoGamesStack.Push("Super Mario Odyssey");
videoGamesStack.Push("Animal Crossing: New Horizons");
//Console.WriteLine(videoGamesStack.Peek()); // Outputs "Animal Crossing: New Horizons" without removing it from the stack
Console.WriteLine("-----------------------------------");

//String myFavoriteGame = videoGamesStack.Pop(); // Removes "Animal Crossing: New Horizons" from the stack
//Console.WriteLine($"My favorite game is: {myFavoriteGame}");
Console.WriteLine("-----------------------------------");


//foreach (var item in videoGamesStack)
//    Console.WriteLine(item);


Console.WriteLine("-----------------------------------");
// Search for a specific game in the stack
//string gameToFind = "Super Mario Odyssey";
//if (videoGamesStack.Contains(gameToFind))
//    Console.WriteLine($"{gameToFind} is in the stack.");
//else
//    Console.WriteLine($"{gameToFind} is not in the stack.");


// Uses of Stack
// 1. Undo functionality in applications
// 2. Backtracking algorithms (e.g., maze solving, depth-first search)
// 3. Expression evaluation (e.g., converting infix to postfix notation)
// 4. Function call management in programming languages (call stack)


// Queue ==> FIFO Data Structure (First In, First Out)
Queue<string> videoGamesQueue = new Queue<string>();
videoGamesQueue.Enqueue("The Legend of Zelda: Breath of the Wild");
videoGamesQueue.Enqueue("Super Mario Odyssey");
videoGamesQueue.Enqueue("Animal Crossing: New Horizons");
//Console.WriteLine(videoGamesQueue.Peek()); // Outputs "The Legend of Zelda: Breath of the Wild" without removing it from the queue
Console.WriteLine("-----------------------------------");

String myFavoriteGame = videoGamesQueue.Dequeue(); // Removes "The Legend of Zelda: Breath of the Wild" from the queue
//Console.WriteLine($"My favorite game is: {myFavoriteGame}");
Console.WriteLine("-----------------------------------");


//foreach (var item in videoGamesQueue)
//    Console.WriteLine(item);


Console.WriteLine("-----------------------------------");
// Search for a specific game in the queue
string gameToFind = "Super Mario Odyssey";
//if (videoGamesQueue.Contains(gameToFind))
//    Console.WriteLine($"{gameToFind} is in the queue.");
//else
//    Console.WriteLine($"{gameToFind} is not in the queue.");


// Uses of Queue
// 1. Print job scheduling
// 2. Task scheduling in operating systems
// 3. Breadth-first search (BFS) in graph algorithms
// 4. Handling requests in web servers
