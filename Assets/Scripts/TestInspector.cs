using System.Collections;
using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;

[CreateAssetMenu(fileName =  "Items", menuName = "BackPack/Items", order = 1)]
public class TestInspector : ScriptableObject
{
    public List<Item> items = new List<Item>();
    

}

