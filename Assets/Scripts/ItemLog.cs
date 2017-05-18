using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLog : MonoBehaviour
{
    public UnityEngine.UI.Text text;

    private void Start()
    {
        text.text = "";
    }


    public void OnItemAction(Item item)
    {
        text.text += item.m_name + "\n";
    }
}
