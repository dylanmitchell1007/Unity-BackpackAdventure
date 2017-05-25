using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TestInspector", menuName = "Inventory/TEST",order = 4)]
public class TestInspector : ScriptableObject
{

    public int items;

    public int backpack
    {
        get { return items / 750; }
    }
}

public class Inventory : Item
{
    
}

