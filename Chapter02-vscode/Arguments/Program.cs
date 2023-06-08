WriteLine($"There are {args.Length} arguments.");

foreach (string arg in args) { WriteLine(arg); }

//arguments from user

if (args.Length < 3)
{
    WriteLine("You must specify two colors and cursor size e.g.");
    WriteLine("dotnet run red yellow 50");
    return;
}

ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[0], true);
BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[1], true);
CursorSize = int.Parse(args[2]);