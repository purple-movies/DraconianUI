using System;
using UnityEngine;
using UnityEngine.UI;

namespace DraconianMarshmallows.UI
{
    public class Modal : UIBehavior
    {
        [SerializeField] private Text messageText; 
        [SerializeField] private ButtonPlus dismissButton;
        
        public Action onDismiss;

        public override void Initialize(IParentUIController parentUIController)
        {
            base.Initialize(parentUIController);
            dismissButton.LabelText = parentUIController.GetLocalizer().GetLocalized("ok");
        }

        public void ShowInfoMessage(string message)
        {
            ShowInfoMessage(message, null);
        }

        public void SetDismissButtonLabel(string label)
        {
            dismissButton.LabelText = label;
        }

        public void ShowWaitingMessage(string message)
        {
            dismissButton.gameObject.SetActive(false);
            messageText.text = message;
            SetActive(true);
        }

        public void Dismiss()
        {
            internalOnDismiss();
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
