using System.Collections;
using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;


public class BackPackBehaviour : MonoBehaviour
{

    public List<Item> Items;
    public int Capacity;
    public BackPackConfig Backpackconfig;
    private void Start()
    {
        Items = new List<Item>();
        foreach (var i in Backpackconfig.items)
            AddItem(i);
    }



    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
            this.transform.position += new Vector3(-0.1f, 0, 0);
        if(Input.GetKey(KeyCode.W))
            this.transform.position += new Vector3(0,0,.1f);
        if(Input.GetKey(KeyCode.S))
            this.transform.position += new Vector3(0,0,-.1f);
        if(Input.GetKey(KeyCode.D))
            this.transform.position += new Vector3(.1f,0,0);
        
    }
    public void LoadBackPack(BackPackConfig newBackpack)
    {
        List<Item> oldItems = new List<Item>();
        oldItems.AddRange(Items);
        Items.Clear();
        foreach (var variable in newBackpack.items)
            AddItem(variable);
        foreach (var variable in oldItems)
            AddItem(variable);
    }
    public void AddItem(Item item)
    {
        if (Items.Count < Capacity)
            Items.Add(item);
    }
    public void RemoveItem(Item item)
    {
        if (Items.Contains(item))
            Items.Remove(item);
    }
}
