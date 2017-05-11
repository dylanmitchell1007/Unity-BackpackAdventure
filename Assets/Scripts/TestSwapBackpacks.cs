using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSwapBackpacks : MonoBehaviour
{
    public BackPackConfig ThisBackPackConfig;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<BackPackBehaviour>().LoadBackPack(ThisBackPackConfig);
        }
    }

}
