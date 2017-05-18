using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR
#endif

[CreateAssetMenu(menuName = ("LootTable"))]
public class LootTable : ScriptableObject
{
    [SerializeField]
    private List<Item> DropResults;
    public List<ItemDrop> Drops;

    [CustomEditor(typeof(LootTable))]
    public class ButtonTest : Editor
    {
        public override void OnInspectorGUI()
        {
            LootTable lootTable = (LootTable)target;
            if (GUILayout.Button("DatButton"))
            {
                lootTable.GetDrops();
            }
            base.OnInspectorGUI();
        }
    }

    public List<Item> GetDrops()
    {
        
        List<Item> DroppableItems = new List<Item>();

       

        foreach (ItemDrop datDrop in Drops)
        {
            float randomdrop = Random.Range(0.0f, 1.0f);
            if (randomdrop < datDrop.ChancetoDrop)
                DroppableItems.Add(datDrop.item);
         


        }
        DropResults = DroppableItems;
        return DroppableItems;

    }



    [System.Serializable]
    public class ItemDrop
    {
        public Item item;
        [Range(0, 1)]
        public float ChancetoDrop;

    }


}
