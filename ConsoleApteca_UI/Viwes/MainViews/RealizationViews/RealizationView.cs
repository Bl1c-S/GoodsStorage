using ConsoleApteca_UI.Viwes;

namespace Console_GS_UI.Viwes.MainViews.RealizationViews
{
    public class RealizationView : ViewBase
    {
        public override void Strategy(char keyChar)
        {
            switch (keyChar)
            {
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                default:
                    Default(keyChar);
                    break;
            }
        }
    }
}