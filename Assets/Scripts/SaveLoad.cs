using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ScriptableObjects;
using UnityEngine;
using UnityEngine.Assertions;
using System.IO;
using System.Runtime.CompilerServices;

//[CreateAssetMenu(fileName = "Save/Load", menuName = "Item/Equipment/BackPack", order = 2)]
//[System.Serializable]
public class SaveLoad : MonoBehaviour
{
    private BackPack backPack;
    private static SaveLoad _instance;
    public BackPackBehaviour BPB;
    public static SaveLoad Instance
    {
        get
        {
            if (!_instance)

            {
                _instance = Resources.FindObjectsOfTypeAll<SaveLoad>().FirstOrDefault();
            }
            if (!_instance)
            {
                _instance = new SaveLoad();


            }
            return _instance;

        }
        set
        {

        }
    }

    void Start()
    {
        BPB = GetComponent<BackPackBehaviour>();
        backPack = ScriptableObject.CreateInstance<BackPack>();
    }

    public void SaveBackPack(string filename, BackPack backPackSaver)
    {
        var path1 = Application.persistentDataPath + "/" + filename + ".json";
        var path2 = Application.persistentDataPath + "/" + filename + ".backpack";
        var save_file1 = JsonUtility.ToJson(backPackSaver, true);
        Debug.Log("You Saved!");
        System.IO.File.WriteAllText(path1, save_file1);
        System.IO.File.WriteAllText(path2, save_file1);
    }

    public BackPack LoadBackPack(string filename)
    {
        var path = Application.persistentDataPath + "/" + filename + ".json";
        var backpack = ScriptableObject.CreateInstance<BackPack>();
        //if (!backpack)
        //{
        //    backpack = Resources.FindObjectsOfTypeAll<BackPack>().FirstOrDefault();
        //    Assert.IsNotNull(backPack, "Should not be Null");
        //}

        var json = System.IO.File.ReadAllText(path);
        JsonUtility.FromJsonOverwrite(json, backpack);
        return backpack;
    }


    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Home))
        {
            backPack.backpackItems = BPB.Items;
            SaveLoad.Instance.SaveBackPack("TestingBackpack", backPack);


        }

        if (Input.GetKeyDown(KeyCode.End))
        {
            backPack.backpackItems = BPB.Items;
            BPB.Items.AddRange(SaveLoad.Instance.LoadBackPack("TestingBackpack").backpackItems);
            BPB.onBackPackChange.Invoke(BPB);

        }
    }
    // Use this for initialization


}