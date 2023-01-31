using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevMenuBeardDrop : MonoBehaviour
{
    public GameObject A_Beard;
    public GameObject A_Beard2;
    public GameObject A_Full;
    public GameObject A_Messy;
    public GameObject A_OldGraham;
    public GameObject A_Santas;
    public GameObject A_Graham;
    public GameObject A_FullMessy;
    public GameObject A_Hippy;
    public GameObject A_Failedshave;


    public void DropdownSample(int Mask)
    {
        switch (Mask)
        {
            case 0: Nothing(); break;
            case 1: Beard(); break;
            case 2: Beard2(); break;
            case 3: Full(); break;
            case 4: Messy(); break;
            case 5: OldGraham(); break;
            case 6: Santas(); break;
            case 7: Graham(); break;
            case 8: FullMessy(); break;
            case 9: Hippy(); break;
            case 10: Failedshave(); break;
        }
    }

    void Nothing()
    {
        A_Beard.SetActive(false);
        A_Beard2.SetActive(false);
        A_Full.SetActive(false);
        A_Messy.SetActive(false);
        A_OldGraham.SetActive(false);
        A_Santas.SetActive(false);
        A_Graham.SetActive(false);
        A_FullMessy.SetActive(false);
        A_Hippy.SetActive(false);
        A_Failedshave.SetActive(false);
    }

    void Beard()
    {
        Nothing();
        A_Beard.SetActive(true);
    }
    
    void Beard2()
    {
        Nothing();
        A_Beard2.SetActive(true);
    }
    
    void Full()
    {
        Nothing();
        A_Full.SetActive(true);
    }   
    
    void Messy()
    {
        Nothing();
        A_Messy.SetActive(true);
    }    
    
    void OldGraham()
    {
        Nothing();
        A_OldGraham.SetActive(true);
    }

    void Santas()
    {
        Nothing();
        A_Santas.SetActive(true);
    }

    void Graham()
    {
        Nothing();
        A_Graham.SetActive(true);
    }

    void FullMessy()
    {
        Nothing();
        A_FullMessy.SetActive(true);
    }

    void Hippy()
    {
        Nothing();
        A_Hippy.SetActive(true);
    }

    void Failedshave()
    {
        Nothing();
        A_Failedshave.SetActive(true);
    }
}
