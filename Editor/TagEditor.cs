using UnityEditor;
using UnityEngine;

namespace JasonSkillman.ScriptableTags.Editor
{
	[CustomEditor(typeof(Tag))]
	public class TagEditor : UnityEditor.Editor
	{
		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();

			Tag tag = (Tag)target;

			EditorGUILayout.LabelField("GUID", tag.GuidString);

			if(GUILayout.Button("Generate new GUID"))
			{
				tag.CreateNewGuid();
			}
		}
	}
}
