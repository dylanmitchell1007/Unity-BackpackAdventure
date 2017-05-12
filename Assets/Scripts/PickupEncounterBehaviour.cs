using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjects;

public class PickupEncounterBehaviour : MonoBehaviour
{
    public GameObject Prefab;
    [HideInInspector]
    public GameObject TmpPrefab;
    // Use this for initialization
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player" && other.GetComponent<BackPackBehaviour>().Items.Count < other.GetComponent<BackPackBehaviour>().Capacity)
        { 
              
            print("Collision");
            ItemBehaviour b = this.GetComponent<ItemBehaviour>();
            other.gameObject.GetComponent<BackPackBehaviour>().AddItem(b.ItemRuntime);
            Destroy(Prefab);
           

        }
       
    }
    
    public void SpawnPrefab()
    {
        TmpPrefab = Instantiate(Prefab, transform.position, transform.rotation);

    }
    // Update is called once per frame
    void Update()
    {

    }
}
