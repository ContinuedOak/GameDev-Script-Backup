using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevMenuHat : MonoBehaviour
{
    public GameObject A_Army;
    public GameObject A_Swat;
    public GameObject A_Football;
    public GameObject A_CowboyCop;
    public GameObject A_GirlyHair;
    public GameObject A_Radioman;
    public GameObject A_Hair;
    public GameObject A_Islander;
    public GameObject A_Rainbow;
    public GameObject A_Hunting;
    public GameObject A_PrisonCut;
    public GameObject A_Default;
    public GameObject A_Jinx;
    public GameObject A_Canada;
    public GameObject A_Snapcap;
    public GameObject A_Policehat;

    public void DropdownSample(int Mask)
    {
        switch (Mask)
        {
            case 0: Nothing(); break;
            case 1: Army(); break;
            case 2: Swat(); break;
            case 3: Football(); break;
            case 4: CowboyCop(); break;
            case 5: Radioman(); break;
            case 6: Hunting(); break;
            case 7: Canada(); break;
            case 8: Snapcap(); break;
            case 9: Policehat(); break;
        }

        void Nothing()
        {
            A_Army.SetActive(false);
            A_Swat.SetActive(false);
            A_Football.SetActive(false);
            A_CowboyCop.SetActive(false);
            A_Radioman.SetActive(false);
            A_Hunting.SetActive(false);
            A_Canada.SetActive(false);
            A_Snapcap.SetActive(false);
            A_Policehat.SetActive(false);
        }

        void Army()
        {
            Nothing();
            A_Army.SetActive(true);
        }

        void Swat()
        {
            Nothing();
            A_Swat.SetActive(true);
        }

        void Football()
        {
            Nothing();
            A_Football.SetActive(true);
        }

        void CowboyCop()
        {
            Nothing();
            A_CowboyCop.SetActive(true);
        }
              

        void Radioman()
        {
            Nothing();
            A_Radioman.SetActive(true);
        }
               
        void Hunting()
        {
                Nothing();
                A_Hunting.SetActive(true);
        }
                
        void Canada()
        {
                Nothing();
                A_Canada.SetActive(true);
        }        
        
        void Snapcap()
        {
                Nothing();
                A_Snapcap.SetActive(true);
        }

        void Policehat()
        {
                Nothing();
                A_Policehat.SetActive(true);
        }
    }
}
