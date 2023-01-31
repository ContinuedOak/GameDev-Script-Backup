using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using UnityEngine.Serialization;

public class DisableMovment : MonoBehaviour
{
    [SerializeField]
    private ThirdPersonController Player;

    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Player")
        {
            Player.GetComponent<ThirdPersonController>().enabled = false;
        }
    }
}
