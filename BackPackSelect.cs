using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackPackSelect : MonoBehaviour
{

    public void DropdownSample(int Mask)
    {
        switch (Mask)
        {
            case 0: Nothing(); break;
            case 1: normal(); break;
            case 2: camping(); break;
            case 3: big(); break;
            case 4: school(); break;
            case 5: pink(); break;
                
        }
    }

    [Header("GameObjects")]
    public GameObject A_normal;
    public GameObject A_camping;
    public GameObject A_big;
    public GameObject A_school;
    public GameObject A_pink;

    void normal()
    {
        Nothing();
        A_normal.SetActive(true);
    }

    void camping()
    {
        Nothing();
        A_camping.SetActive(true);
    }

    void big()
    {
        Nothing();
        A_big.SetActive(true);
    }

    void school()
    {
        Nothing();
        A_school.SetActive(true);
    }

    void pink()
    {
        Nothing();
        A_pink.SetActive(true);
    }

    void Nothing()
    {
        A_pink.SetActive(false);
        A_camping.SetActive(false);
        A_big.SetActive(false);
        A_school.SetActive(false);
        A_normal.SetActive(false);
    }
}
