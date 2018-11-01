using DraconianMarshmallows.UI.Localization;
using UnityEngine.EventSystems;

namespace DraconianMarshmallows.UI
{
    public class UIBehavior : UIBehaviour
    {
        protected IParentUIController parentUIController;

        ///<summary>Used to initialize UI from a parent controller that's set necessary properties.</summary>
        public virtual void Initialize(IParentUIController parentUIController)
        {
            this.parentUIController = parentUIController;
        }

        public virtual void SetActive(bool active)
        {
            gameObject.SetActive(active);
        }
    }
}
