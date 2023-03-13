namespace Console_GS_UI.Viwes.MainViews.ReceivingViews;

public class ReceivingView : ViewBase
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