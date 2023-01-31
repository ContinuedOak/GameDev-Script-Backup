using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevMenuGlasses : MonoBehaviour
{
    public GameObject A_Glasses1;
    public GameObject A_Glasses2;
    public GameObject A_Glasses3;
    public GameObject A_Eyepatch;

    public void DropdownSample(int Mask)
    {
        switch (Mask)
        {
            case 0: Nothing(); break;
            case 1: Glasses1(); break;
            case 2: Glasses2(); break;
            case 3: Glasses3(); break;
            case 4: Eyepatch(); break;

        }

    }

    public void Nothing()
    {
        A_Glasses1.SetActive(false);
        A_Glasses2.SetActive(false);
        A_Glasses3.SetActive(false);
        A_Eyepatch.SetActive(false);
    }

    public void Glasses1()
    {
        Nothing();
        A_Glasses1.SetActive(true);
    }

    public void Glasses2()
    {
        Nothing();
        A_Glasses2.SetActive(true);
    }

    public void Glasses3()
    {
        Nothing();
        A_Glasses3.SetActive(true);
    }

    public void Eyepatch()
    {
        Nothing();
        A_Eyepatch.SetActive(true);
    }
}