using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "BackPack", menuName = "Item/Equipment/BackPack", order = 2)]
    public class BackPack : Equipment
    {
        public List<Item> backpackItems;
        // Use this for initialization
        
    }


}