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
    }
}
