using UnityEditor.UI;
using UnityEditor;

namespace DraconianMarshmallows.UI
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(ButtonPlus), true)]
    public class ButtonPlusEditor : ButtonEditor
    {
        SerializedProperty mLabel;

        protected override void OnEnable()
        {
            base.OnEnable();
            mLabel = serializedObject.FindProperty("labelTextComponent");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update(); 
            base.OnInspectorGUI();
            EditorGUILayout.PropertyField(mLabel);
            serializedObject.ApplyModifiedProperties(); 
        }
    }
}
