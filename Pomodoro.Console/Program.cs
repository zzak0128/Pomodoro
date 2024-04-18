using Pomodoro.Console.Menus;
using Pomodoro.Library.Enums;

Console.Clear();

        Console.WriteLine("""
 ____  _____  __  __  _____  ____  _____  ____  _____ 
(  _ \(  _  )(  \/  )(  _  )(  _ \(  _  )(  _ \(  _  )
 )___/ )(_)(  )    (  )(_)(  )(_) ))(_)(  )   / )(_)( 
(__)  (_____)(_/\/\_)(_____)(____/(_____)(_)\_)(_____)
""");

Console.WriteLine("Press Enter to Start Pomodoro");
Console.ReadLine();

AppStatus appStatus = MainMenu.Open();
while (appStatus == AppStatus.Running)
{
   appStatus = MainMenu.Open();
}
