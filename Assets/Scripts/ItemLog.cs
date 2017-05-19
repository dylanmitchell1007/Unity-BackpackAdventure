using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLog : MonoBehaviour
{
    public UnityEngine.UI.Text text;
    private float timer = 0f;
    private string firstSequence = "";
    private void Start()
    {
        text.text = "";
    }

    void Update()
    {
        if (timer > 7)
        {
            text.text = text.text.TrimStart(firstSequence.ToCharArray()) ;
            timer = 0f;
        }
        timer += Time.deltaTime;
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
        for (int i = 0; i < text.text.Length; i++)
        {
            firstSequence += text.text[i];
            if (firstSequence[i] == '\n')
                break;
        }
        
    }
}
