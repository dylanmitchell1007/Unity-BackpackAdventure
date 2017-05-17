using System.Collections;
using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;
using UnityEngine.Events;


public class BackPackBehaviour : MonoBehaviour
{

    public List<Item> Items;
    public int Capacity;
    public BackPackConfig Backpackconfig;
    [System.Serializable]
    public class OnBackPackChange : UnityEvent<BackPackBehaviour>
    {
    }

    public OnBackPackChange onBackPackChange;
    private void Start()
    {
        Items = new List<Item>();
        foreach (var i in Backpackconfig.Items)
            AddItem(i);
    }



    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
            this.transform.position += new Vector3(-0.1f, 0, 0);
        if (Input.GetKey(KeyCode.W))
            this.transform.position += new Vector3(0, 0, .1f);
        if (Input.GetKey(KeyCode.S))
            transform.position += new Vector3(0, 0, -.1f);
        if (Input.GetKey(KeyCode.D))
            this.transform.position += new Vector3(.1f, 0, 0);

       
    }

    public void LoadBackPackIn(BackPackConfig newBackpack)
    {
        List<Item> oldItems = new List<Item>();
        oldItems.AddRange(Items);
        Items.Clear();
        foreach (var variable in newBackpack.Items)
            AddItem(variable);
        foreach (var variable in oldItems)
            AddItem(variable);
    }

    public void AddItem(Item item)
    {
        if (Items.Count < Capacity)
        {
            Items.Add(item);
            onBackPackChange.Invoke(this);
        }
    }

    public void RemoveItem(Item item)
    {
        if (Items.Contains(item))
        {
            Items.Remove(item);
            onBackPackChange.Invoke(this);
            
        }
    }
}
