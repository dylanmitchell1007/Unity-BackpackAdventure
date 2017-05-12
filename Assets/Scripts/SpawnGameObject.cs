using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjects;
public class SpawnGameObject : MonoBehaviour
{

    public GameObject Prefab;
    public GameObject TmpPrefab;
    public void SpawnPrefab()
    {
        TmpPrefab = Instantiate(Prefab, transform.position, transform.rotation);
        
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnPrefab();
        }
    }
}