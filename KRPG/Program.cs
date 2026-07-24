using KRPG.Entities.Character.Player;
using KRPG.Components;
using KRPG.Systems.Other;
using KRPG.Systems.Screens;
using KRPG.Systems.Screens.ScreenResults;

namespace KRPG;

class Program
{
    static void Main()
    {
        Console.CursorVisible = false;
        TitleScreen screen = new TitleScreen();
        screen.Show();

        switch (screen.Result)
        {
            case TitleScreenResult.NewGame:
                Console.WriteLine("You created a new game");
                break;
            case TitleScreenResult.LoadGame:
                Console.WriteLine("You created a new game");
                break;
        }
    }
}