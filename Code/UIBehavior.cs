using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DraconianMarshmallows.UI
{
    public class UIBehavior : UIBehaviour
    {
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
