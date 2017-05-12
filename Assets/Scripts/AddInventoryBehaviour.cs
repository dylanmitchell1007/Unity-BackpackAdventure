using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjects;
public class AddInventoryBehaviour : MonoBehaviour {
    public void AddonPickup(Item item)
    {
        GetComponent<BackPackBehaviour>().AddItem(item);

    }
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
   
}
