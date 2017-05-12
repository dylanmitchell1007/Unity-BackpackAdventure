using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Item : ScriptableObject    {

        public int id;
        public string m_name;

        public static explicit operator GameObject(Item v)
        {
            throw new NotImplementedException();
        }
    }