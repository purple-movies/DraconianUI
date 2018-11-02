using UnityEditor.UI;
using UnityEditor;

namespace DraconianMarshmallows.UI
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(TextInput), true)]
    public class TextInputEditor : InputFieldEditor
    {
        SerializedProperty mErrorText;
        SerializedProperty mPlaceHolderText;

        protected override void OnEnable()
        {
            base.OnEnable();
            mErrorText = serializedObject.FindProperty("errorTextComponent");
            mPlaceHolderText = serializedObject.FindProperty("placeHolderText");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            base.OnInspectorGUI();
            EditorGUILayout.PropertyField(mErrorText);
            EditorGUILayout.PropertyField(mPlaceHolderText);
            serializedObject.ApplyModifiedProperties();
        }
    }
}
