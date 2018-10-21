using System;
using UnityEngine;
using UnityEngine.UI;

namespace DraconianMarshmallows.UI
{
    public class Modal : UIBehavior
    {
        [SerializeField] private Text messageText; 
        [SerializeField] private Button dismissButton;
        [SerializeField] private Text dismissButtonText; 
        
        private Action onDismiss;

        public void ShowInfoMessage(string message)
        {
            ShowInfoMessage(message, null);
        }

        public void SetDismissButton(string label)
        {
            dismissButtonText.text = label;
        }

        private void ShowInfoMessage(string message, Action onDismiss)
        {
            messageText.text = message;
            if (onDismiss != null) this.onDismiss += onDismiss;
            dismissButton.onClick.AddListener(internalOnDismiss);
            SetActive(true);
        }

        private void internalOnDismiss()
        {
            if (onDismiss != null) onDismiss();
            dismissButton.onClick.RemoveAllListeners(); 
            SetActive(false);
        }
    }
}
