using DraconianMarshmallows.UI.Localization;
using UnityEngine.EventSystems;

namespace DraconianMarshmallows.UI
{
    public class UIBehavior : UIBehaviour
    {
        public Localizer Localizer; 

        protected override void Start()
        {
            base.Start();
        }

        public virtual void SetActive(bool active)
        {
            gameObject.SetActive(active);
        }
    }
}
