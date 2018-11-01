using DraconianMarshmallows.UI.Localization;

namespace DraconianMarshmallows.UI
{
    /// <summary>
    /// Interface for child UI controllers to commicate upwards after initialization. 
    /// </summary>
    public interface IParentUIController
    {
        Localizer GetLocalizer(); 
    }
}
