using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DraconianMarshmallows.UI
{
    public class ConfirmOrCancelPanel : UIBehavior
    {
        [SerializeField] private Button confirmButton;
        [SerializeField] private Button cancelButton;

        protected override void Start()
        {
            base.Start();

        }
    }
}
