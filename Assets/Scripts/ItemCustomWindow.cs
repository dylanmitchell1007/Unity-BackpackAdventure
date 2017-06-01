using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;


public class ItemCustomWindow : EditorWindow
{
    private string itemName;
    private string itemDescription;

    public static void ShowWindow()
    {
        EditorWindow window = EditorWindow.GetWindow(typeof(ItemCustomWindow));
        EditorGUILayout.EndHorizontal();
        GUILayout.Label("Items in BackPack:");
        window.maxSize = new Vector2(500, 420);
        window.minSize = window.maxSize;
        if (GUILayout.Button("Shuffle"))
        {
            List<Item> item = new List<Item>();

        }
    }





}
   

    
  
    