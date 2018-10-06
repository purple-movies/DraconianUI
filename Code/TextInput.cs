using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace DraconianMarshmallows.UI
{
    public class TextInput : InputField
    {
        [SerializeField] private Text errorTextComponent;

        protected override void Start()
        {
            base.Start();
            errorTextComponent.gameObject.SetActive(false); 
        }

        public void ShowError(string error)
        {
            errorTextComponent.text = text;
            errorTextComponent.gameObject.SetActive(true);
        }

        public void HideError()
        {
            errorTextComponent.gameObject.SetActive(false);
        }
    }
}
