// int numberOfApples = 12;
// decimal pricePerApple = 0.35M;

// Console.WriteLine(
//     format: "{0} apples cost {1:C}",
//     arg0: numberOfApples,
//     arg1: pricePerApple * numberOfApples);

// string formatted = string.Format(
//     format: "{0} apples cost {1:C}",
//     arg0: numberOfApples,
//     arg1: pricePerApple * numberOfApples);

// Console.WriteLine($"This is the interpolated string! {numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

// string applesText = "Apples";
// int applesCount = 1234;
// string bananasText = "Bananas";
// int bananasCount = 56789;

// Console.WriteLine($"{"Name",-10} {"Count",6}");
// Console.WriteLine($"{applesText,-10} {applesCount,6:N0}");
// Console.WriteLine($"{bananasText,-10} {bananasCount,6:N0}");

//text input
// WriteLine("Type your first name and press ENTER: ");
// string firstName = Console.ReadLine();
// WriteLine($"Hello {firstName}, type your age and press ENTER: ");
// string age = Console.ReadLine();
// WriteLine($"Hello {firstName}, you look like shit for being {age} years old.");

//key input
Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine($"Key: {key.Key}, Char: {key.KeyChar}, Modifiers: {key.Modifiers}");