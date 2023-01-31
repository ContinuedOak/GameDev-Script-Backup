using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMoney : MonoBehaviour
{
    PlayersMoney Bank;

    /*[SerializeField] private */GameObject lowStore;
    /*[SerializeField] private */GameObject midStore;
    /*[SerializeField] private */GameObject highStore;


    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "lowCash")
        {

            Bank.Cash = Bank.Cash + Random.Range(50, 350);
            Destroy(lowStore);
        }

        if (Col.gameObject.tag == "midCash")
        {

            Bank.Cash = Bank.Cash + Random.Range(120, 769);
            Destroy(midStore);
        }

        if (Col.gameObject.tag == "highCash")
        {

            Bank.Cash = Bank.Cash + Random.Range(420, 1500);
            Destroy(highStore);
        }

    }
}
