using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjects;
public class AddInventoryBehaviour : MonoBehaviour {
    public void AddonPickup()
    {
        GetComponent<BackPackBehaviour>().AddItem(Item)

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	
}
