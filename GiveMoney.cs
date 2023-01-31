using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveMoney : MonoBehaviour
{
    [Header("MoneyDrop")]
    [SerializeField]
    private bool MoneyRain = false;
    
    [SerializeField]
    private Transform Point;
    
    [SerializeField]
    private GameObject Moneybag;


    void Update()
    {
        if (MoneyRain)
        {
            Instantiate(Moneybag);
        }
    }
}
