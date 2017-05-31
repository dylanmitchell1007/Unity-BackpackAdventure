using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using NUnit.Framework.Constraints;
using NUnit.Framework.Internal;
using ScriptableObjects;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.Events;

[CustomEditor(typeof(BackPackBehaviour))]
public class InspectorTest : UnityEditor.Editor
{
  
    
    public override void OnInspectorGUI()
    {
        List<Item> I = new List<Item>();
        BackPack pack = target as BackPack;
        BackPackBehaviour T = target as BackPackBehaviour;
        if (GUILayout.Button("Shuffle"))
        {
            GUILayout.
            T.Items.Capacity = int.MaxValue;
          

        }
        if (T.Items.Capacity != int.MaxValue)
        {
            
            T.Capacity = EditorGUILayout.IntSlider(T.Capacity, 0, 50);
        }
    }
}
