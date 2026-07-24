using KRPG.Helper;
using KRPG.Interfaces;
using KRPG.Systems.Other;
using KRPG.Systems.Screens.ScreenResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Systems.Screens
{
    public class TitleScreen : IScreen
    {
        const string TITLE = "KRPG";
        public TitleScreenResult Result { get; private set; }
        public TitleScreen()
        {

        }

        public void Show()
        {
            SelectionMenu menu = new SelectionMenu(TITLE, TextFormatter.FormatEnumName<TitleScreenResult>());
            Result = (TitleScreenResult)menu.Show();
        }
    }
}
