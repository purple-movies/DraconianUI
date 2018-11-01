using UnityEditor.UI;
using UnityEditor;

namespace DraconianMarshmallows.UI
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(TextInput), true)]
    public class TextInputEditor : InputFieldEditor
    {
        SerializedProperty mErrorText;

        protected override void OnEnable()
        {
            base.OnEnable();
            mErrorText = serializedObject.FindProperty("errorTextComponent");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            base.OnInspectorGUI();
            EditorGUILayout.PropertyField(mErrorText);
            serializedObject.ApplyModifiedProperties();
        }
    }
}
