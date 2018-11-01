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

        private Text placeHolderText;

        public string PlaceHolder
        {
            get
            {
                return placeHolderText.text;
            }
            set
            {
                placeHolderText.text = value;
            }
        }

        protected override void Start()
        {
            base.Start();
            errorTextComponent.gameObject.SetActive(false);
            placeHolderText = placeholder.GetComponent<Text>(); 
        }

        public void ShowError(string error)
        {
            errorTextComponent.text = error;
            errorTextComponent.gameObject.SetActive(true);
        }

        public void HideError()
        {
            errorTextComponent.gameObject.SetActive(false);
        }
    }
}
