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

    void OnEnable()
    {
        PickupEncounterBehaviour.OnEvent.AddListener(OnItemAction);
    }

    void OnDisable()
    {
        PickupEncounterBehaviour.OnEvent.RemoveListener(OnItemAction);
    }
    public void OnItemAction(Item item)
    {
        text.text += "Item picked up: " + item.m_name + "\n";
    }
}
