using Pomodoro.Console;

Console.WriteLine("Hello World");

Menu menu = new Menu("Pomodoro", new List<string>{
    "Item1", "Item2", "Item3"
});

menu.Start();
System.Console.ReadLine();