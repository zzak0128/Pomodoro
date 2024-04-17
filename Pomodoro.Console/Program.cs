using Pomodoro.Console.Menus;
using Pomodoro.Library.Enums;

Console.WriteLine("""
 ____  _____  __  __  _____  ____  _____  ____  _____ 
(  _ \(  _  )(  \/  )(  _  )(  _ \(  _  )(  _ \(  _  )
 )___/ )(_)(  )    (  )(_)(  )(_) ))(_)(  )   / )(_)( 
(__)  (_____)(_/\/\_)(_____)(____/(_____)(_)\_)(_____)
""");

AppStatus appStatus = MainMenu.Open();
while (appStatus == AppStatus.Running)
{
   appStatus = MainMenu.Open();
}
