using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjects;
using UnityEngine.Events;

public class ItemBehaviour : MonoBehaviour {
    public Item ItemConfig;
    //[HideInInspector]
    public Item ItemRuntime;
    public void Start()
    {
       ItemRuntime = Instantiate(ItemConfig);
        
    }
   
   
}
