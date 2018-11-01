using UnityEngine;
using UnityEngine.UI;

namespace DraconianMarshmallows.UI
{
    public class ButtonPlus : Button
    {
        [SerializeField] private Text labelTextComponent; 

        public string LabelText { set { labelTextComponent.text = value; } }
    }
}
