using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DraconianMarshmallows.UI
{
    public class TextEntryPanel : UIBehavior
    {
        [SerializeField] private InputField inputField;
        [SerializeField] private Text errorText;

        protected override void Start()
        {
            base.Start();
            errorText.gameObject.SetActive(false);
        }
    }
}
