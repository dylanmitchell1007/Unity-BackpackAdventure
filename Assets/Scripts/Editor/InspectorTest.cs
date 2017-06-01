using Boo.Lang;
using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.Events;

[CustomEditor(typeof(TestInspector))]
public class InspectorTest : Editor
{
    TestInspector As;
    void OnEnable()
    {
        As = (TestInspector)target;
    }


    public override void OnInspectorGUI()
    {
        EditorGUILayout.BeginHorizontal("Box");
        GUILayout.Label("Items in BackPack:" + As.items.Count);
        if (GUILayout.Button("Add Weapon"))
        {
            GUILayout.BeginScrollView(Vector2.down);
            List<Item> item = new List<Item>();
            GUILayout.Label("Items in BackPack:" + As.items.Count);
            ItemCustomWindow.ShowWindow();


        }
        EditorGUILayout.EndHorizontal();
    }
}

