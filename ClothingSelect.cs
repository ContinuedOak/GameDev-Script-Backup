using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothingSelect : MonoBehaviour
{
    public DevMenu DevMenuHeader;

    [Header("Buttons")]
    public Button B_Headgear;
    public Button B_Backpack;
    public Button B_Carrier;
    public Button B_Lefthand;
    public Button B_Righthand;
    public Button B_Home;

    [Header("GameObject")]
    public GameObject A_Headgear;
    public GameObject A_Backpack;
    public GameObject A_Carrier;
    public GameObject A_Lefthand;
    public GameObject A_Righthand;
    public GameObject A_Home;

    void Start()
    {
        Button Headgearbtn = B_Headgear.GetComponent<Button>();
        Headgearbtn.onClick.AddListener(Headgear);
        
        Button Homebtn = B_Home.GetComponent<Button>();
        Homebtn.onClick.AddListener(Home);

        Button Backpackbtn = B_Backpack.GetComponent<Button>();
        Backpackbtn.onClick.AddListener(Backpack);

        Button Carrierbtn = B_Carrier.GetComponent<Button>();
        Carrierbtn.onClick.AddListener(Carrier);

        Button Lefthandbtn = B_Lefthand.GetComponent<Button>();
        Lefthandbtn.onClick.AddListener(Lefthand);

        Button Righthandbtn = B_Righthand.GetComponent<Button>();
        Righthandbtn.onClick.AddListener(Righthand);
    }

    void Headgear()
    {
        A_Headgear.SetActive(true);
        Debug.Log("Selected Headgear.");
        DevMenuHeader.Header.text = "HeadGear";

        A_Backpack.SetActive(false);
        A_Carrier.SetActive(false);
        A_Lefthand.SetActive(false);
        A_Righthand.SetActive(false);
        A_Home.SetActive(false);
    }

    void Backpack()
    {
        A_Backpack.SetActive(true);
        Debug.Log("Selected Backpack!.");
        DevMenuHeader.Header.text = "Backpack";

        A_Headgear.SetActive(false);
        A_Carrier.SetActive(false);
        A_Lefthand.SetActive(false);
        A_Righthand.SetActive(false);
        A_Home.SetActive(false);
    }

    void Carrier()
    {
        A_Carrier.SetActive(true);
        Debug.Log("Selected Carreir/Carrier/Carreerirer?? - fuk spelling man!.");
        DevMenuHeader.Header.text = "Side/Misc";

        A_Backpack.SetActive(false);
        A_Headgear.SetActive(false);
        A_Lefthand.SetActive(false);
        A_Righthand.SetActive(false);
        A_Home.SetActive(true);
    }

    void Lefthand()
    {
        A_Lefthand.SetActive(true);
        Debug.Log("Selected Left Hand!.");
        DevMenuHeader.Header.text = "Left Hand";

        A_Backpack.SetActive(false);
        A_Headgear.SetActive(false);
        A_Lefthand.SetActive(false);
        A_Righthand.SetActive(false);
        A_Home.SetActive(true);
    }

    void Righthand()
    {
        A_Righthand.SetActive(true);
        Debug.Log("Selected Right Hand!.");
        DevMenuHeader.Header.text = "Right Hand";

        A_Backpack.SetActive(false);
        A_Carrier.SetActive(false);
        A_Lefthand.SetActive(false);
        A_Headgear.SetActive(false);
        A_Home.SetActive(true);
    }

    void Home()
    {
        A_Home.SetActive(false);
        A_Backpack.SetActive(false);
        A_Carrier.SetActive(false);
        A_Lefthand.SetActive(false);
        A_Headgear.SetActive(false);
        A_Righthand.SetActive(false);
    }
}
