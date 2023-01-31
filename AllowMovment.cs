using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class AllowMovment : MonoBehaviour
{
    public ThirdPersonController Controller;

    void OnTriggerEnter(Collider other)
    {
            Controller.GetComponent<ThirdPersonController>().enabled = true;
    }
}