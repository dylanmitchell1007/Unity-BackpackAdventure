using System.Collections;
using System.Collections.Generic;
using System.Text;
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
        if (timer > 3)
        {
            bool found = false;
            for (int i = 0; i < text.text.Length; i++)
            {
                if (text.text[i] == firstSequence[0])
                    for (int j = 0; j < firstSequence.Length; j++)
                    {
                        if (text.text[j + i] != firstSequence[j])
                            break;
                        if (j == firstSequence.Length - 1)
                            found = true;
                    }
                if (found)
                {
                    text.text = text.text.Remove(i, firstSequence.Length);
                    firstSequence = "";
                    for (int k = 0; k < text.text.Length; k++)
                    {
                        firstSequence += text.text[k];
                        if (firstSequence[k] == '\n')
                            break;
                    }
                    found = false;
                    break;
                }
            }
            
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
        firstSequence = "";
        for (int i = 0; i < text.text.Length; i++)
        {
            firstSequence += text.text[i];
            if (firstSequence[i] == '\n')
                break;
        }
        
    }
}
