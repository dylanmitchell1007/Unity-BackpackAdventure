using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

[CustomEditor(typeof(TestInspector))]
public class InspectorTest : Editor
{
    public Text call;
    public override void OnInspectorGUI()
    {
        TestInspector mybackpack = (TestInspector)target;

        
        mybackpack.items = EditorGUILayout.IntField("Inventory", mybackpack.items);
        EditorGUILayout.LabelField("Items", mybackpack.items.ToString());
        EditorGUILayout.("YOU PRESSED A BUTTON", name);
        EditorGUILayout.DropdownButton(GUIContent.none, FocusType.Keyboard);

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
