namespace RefactorSample.ComposingMethod.ExtractVariable;

public class After
{
    private string _platform;
    private string _browser;
    private int _resize;

    public void RenderBanner()
    {
        bool isMacOs = _platform.ToUpper().IndexOf("MAC") > -1;
        bool isIE = _browser.ToUpper().IndexOf("IE") > -1;
        bool wasResize = this._resize > 0;
        if (isMacOs && isIE && WasInitialized() && wasResize)
        {
            // do something
        }
    }

    private bool WasInitialized()
    {
        return true;
    }
}