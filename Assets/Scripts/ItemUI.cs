using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemUI : MonoBehaviour
{
    public BackPackBehaviour items;
    public Text ItemText;

    public void ChangeItemText()
    {
        ItemText.text = "BackPack items: \n";
        foreach (var item in items.Items)
        {
            ItemText.text += item.m_name + "\n";
        }
    }
}
