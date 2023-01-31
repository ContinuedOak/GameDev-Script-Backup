using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevMenuHairDrop : MonoBehaviour
{
    [Header("Female")]
    public GameObject A_girl1;
    public GameObject A_girl2;
    public GameObject A_girl3;
    public GameObject A_girl4;
    public GameObject A_girl5;
    public GameObject A_girl6;
    public GameObject A_girl7;

    [Header("Male")]
    public GameObject A_boy1;
    public GameObject A_boy2;
    public GameObject A_boy3;
    public GameObject A_boy4;
    public GameObject A_boy5;

    [Header("Both")]
    public GameObject A_both1;



    public void DropdownSample(int Mask)
    {
        switch (Mask)
        {
            case 0: Nothing(); break;
            case 1: Girl1(); break;
            case 2: Girl2(); break;
            case 3: Girl3(); break;
            case 4: Girl4(); break;
            case 5: Girl5(); break;
            case 6: Girl6(); break;
            case 7: Girl7(); break;
           
            case 8: Boy1(); break;
            case 9: Boy2(); break;
            case 10: Boy3(); break;
            case 11: Boy4(); break;
            case 12: Boy5(); break;
            
            case 13: Both1(); break;
        }
    }

    void Nothing()
    {
        A_girl1.SetActive(false);
        A_girl2.SetActive(false);
        A_girl3.SetActive(false);
        A_girl4.SetActive(false);
        A_girl5.SetActive(false);
        A_girl6.SetActive(false);
        A_girl7.SetActive(false);

        A_boy1.SetActive(false);
        A_boy2.SetActive(false);
        A_boy3.SetActive(false);
        A_boy4.SetActive(false);
        A_boy5.SetActive(false);

        A_both1.SetActive(false);
    }

    void Girl1()
    {
        Nothing();
        A_girl1.SetActive(true);
    }

    void Girl2()
    {
        Nothing();
        A_girl2.SetActive(true);
    }

    void Girl3()
    {
        Nothing();
        A_girl3.SetActive(true);
    }

    void Girl4()
    {
        Nothing();
        A_girl4.SetActive(true);
    }

    void Girl5()
    {
        Nothing();
        A_girl5.SetActive(true);
    }

    void Girl6()
    {
        Nothing();
        A_girl6.SetActive(true);
    }

    void Girl7()
    {
        Nothing();
        A_girl7.SetActive(true);
    }
    
    // BREAK

    void Boy1()
    {
        Nothing();
        A_boy1.SetActive(true);
    }

    void Boy2()
    {
        Nothing();
        A_boy2.SetActive(true);
    }

    void Boy3()
    {
        Nothing();
        A_boy3.SetActive(true);
    }

    void Boy4()
    {
        Nothing();
        A_boy4.SetActive(true);
    }

    void Boy5()
    {
        Nothing();
        A_boy5.SetActive(true);
    }

    void Both1()
    {
        Nothing();
        A_both1.SetActive(true);
    }
}
