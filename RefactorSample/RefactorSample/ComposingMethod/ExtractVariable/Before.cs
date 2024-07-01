using System.Net.NetworkInformation;

namespace RefactorSample.ComposingMethod.ExtractVariable;

public class Before
{
    private string _platform;
    private string _browser;
    private int _resize;
     
    public void RenderBanner()
    {
        if ((_platform.ToUpper().IndexOf("MAC") > -1) &&
            (_browser.ToUpper().IndexOf("IE") > -1) &&
            WasInitialized() && _resize > 0 )
        {
            // do something
        }        
    }

    private bool WasInitialized()
    {
        return true;
    }
}