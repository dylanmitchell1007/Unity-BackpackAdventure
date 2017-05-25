﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjects;
using System;

public class ItemRemove : MonoBehaviour
{
    public GameObject Prefab;
    //void Throw()
    //{
    //    var Kb = GetComponent<BackPackBehaviour>();
    //   var Ab = Instantiate(Resources.Load("GameItem/") as Item);
    //    Ab.RemoveItem(item);
    //    if (Kb.Items.Count <= 12)
    //        Kb.AddItem(Kb.Items[0]);


    //}

    void Remove()
    {
        var Rem = GetComponent<BackPackBehaviour>();
        if (Rem.Items.Count > 0)
        {
            var datObject = Instantiate(Prefab);
            datObject.GetComponent<ItemBehaviour>().ItemConfig = Rem.Items[0];
            datObject.transform.position = this.transform.position + (this.transform.forward * 3);
            if (Rem.Items.Count > 0)
                Rem.RemoveItem(Rem.Items[0]);
        }
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Delete))
        {
            Remove();

        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            //Throw();

        }
    }


}
