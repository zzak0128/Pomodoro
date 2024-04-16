namespace Pomodoro.Console;

public class Menu
{
    public string Title { get; set; }

    public int SelectedIndex { get; set; }

    public List<string> MenuOptions { get; set; }

    public Menu(string title, List<string> menuOptions)
    {
        Title = title;
        MenuOptions = menuOptions;
    }

    public int Start()
    {
        System.Console.WriteLine(Title);

        Render(0);

        ConsoleKeyInfo keyPressed = System.Console.ReadKey();

        while (keyPressed.Key != ConsoleKey.Escape)
        {
            switch (keyPressed.Key)
            {
                case ConsoleKey.UpArrow:

                    if (SelectedIndex == 0)
                    {
                        SelectedIndex = MenuOptions.Count - 1;
                        break;
                    }

                    SelectedIndex -= 1;
                    break;

                case ConsoleKey.DownArrow:
                    if (SelectedIndex == MenuOptions.Count - 1)
                    {
                        SelectedIndex = 0;
                        break;
                    }

                    SelectedIndex += 1;
                    break;

                case ConsoleKey.Enter:
                    return SelectedIndex;
                default:
                    break;
            }

            Render(SelectedIndex);
            keyPressed = System.Console.ReadKey();
        }
        return SelectedIndex;
    }

    private void Render(int selectedIndex)
    {
        System.Console.Clear();
        System.Console.CursorVisible = false;
        System.Console.Title = Title;

        for (int i = 0; i < MenuOptions.Count; i++)
        {
            var option = MenuOptions[i];
            if (selectedIndex == i)
            {
                System.Console.BackgroundColor = ConsoleColor.White;
                System.Console.ForegroundColor = ConsoleColor.Black;
                System.Console.WriteLine(option);
                System.Console.ResetColor();
            }
            else
            {
                System.Console.WriteLine(option);
            }
        }
    }
}
