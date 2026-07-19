using KRPG.Entities.Character.Player;
using KRPG.Components;

namespace KRPG;

class Program
{
    static void Main()
    {
        Player player = new Player("Test", new Stats());
        Player player2 = new Player("2test2", new Stats());
    }
}