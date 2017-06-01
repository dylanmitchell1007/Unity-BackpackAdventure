using System.Linq;
using Boo.Lang;
using NUnit.Framework.Constraints;
using ScriptableObjects;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

using UnityEngine.UI;
using UnityEngine.Events;

[CustomEditor(typeof(TestInspector))]
public class InspectorWindowEditorScript : EditorWindow
{

    public BackPackBehaviour plyer;
    //TestInspector As;

    void OnEnable()
    {
        plyer = FindObjectOfType<BackPackBehaviour>();
        Debug.Log(plyer.name);
    }


    [MenuItem("Tools/Items %g")]
    static void Init()
    {
        var window = EditorWindow.GetWindow(typeof(InspectorWindowEditorScript)) as InspectorWindowEditorScript;
        window.Show();
    }


    public void OnGUI()
    {
        EditorGUILayout.BeginHorizontal("Box");
        GUILayout.Label("Items in BackPack:" + plyer.Items.Count);
        var plyerItems = GameObject.FindObjectOfType<BackPackBehaviour>().Items;
        if (GUILayout.Button("Remove Item"))
        {
            var temp = plyer.Items[plyer.Items.Count - 1];
            plyer.RemoveItem(temp);
            Destroy(temp);
        }

        string items = "";
        plyerItems.ForEach(x => { items += x.m_name + "\n"; });

        GUILayout.Space(20);
        GUILayout.Box(items);
        plyer = FindObjectOfType<BackPackBehaviour>();
    }
}

