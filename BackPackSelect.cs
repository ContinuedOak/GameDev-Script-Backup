using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackPackSelect : MonoBehaviour
{

    public void DropdownSample(int Mask)
    {
    // Name of "Mask Type" to run its function
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
// Model of "Mask Type" to run in its function
    [Header("GameObjects")]
    public GameObject A_normal;
    public GameObject A_camping;
    public GameObject A_big;
    public GameObject A_school;
    public GameObject A_pink;

    void normal()
    {
        Nothing(); // This disables the all of the models of the mask
        A_normal.SetActive(true); // so that this can show the mask, if this was first it would be disabled.
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
    // Remember to add the new mask model here to disable
        A_pink.SetActive(false);
        A_camping.SetActive(false);
        A_big.SetActive(false);
        A_school.SetActive(false);
        A_normal.SetActive(false);
    }
}
