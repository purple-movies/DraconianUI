using DraconianMarshmallows.UI;
using DraconianMarshmallows.UI.Localization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentUIController : UIBehavior, IParentUIController
{
    protected Localizer localizer;

    public Localizer GetLocalizer()
    {
        return localizer; 
    }
}
