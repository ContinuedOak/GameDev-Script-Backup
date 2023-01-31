using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DevMenu : MonoBehaviour
{
    //public HatSelection HatTypes;
    // Developer Notes!

    // These Reads what option is picked on Home Page.
    // B_ is here
    [Header("Buttons")]
    public Button B_PlayerStatus;
    public Button B_PlayerOptions;
    public Button B_VehicleOptions;
    public Button B_TeleportOptions;
    public Button B_WeaponOptions;
    public Button B_TimeOption;
    public Button B_ObjectSpooner;
    public Button B_MiscOptions;
    public Button B_Home;
    

    void Start()
    {
        Button PlayerStatusbtn = B_PlayerStatus.GetComponent<Button>();
        PlayerStatusbtn.onClick.AddListener(PlayerStatus);

        Button PlayerOptionsbtn = B_PlayerOptions.GetComponent<Button>();
        PlayerOptionsbtn.onClick.AddListener(PlayerOptions);

        Button VehicleOptionsbtn = B_VehicleOptions.GetComponent<Button>();
        VehicleOptionsbtn.onClick.AddListener(VehicleOptions);

        Button TeleportOptionsbtn = B_TeleportOptions.GetComponent<Button>();
        TeleportOptionsbtn.onClick.AddListener(TeleportOptions);

        Button WeaponOptionsbtn = B_WeaponOptions.GetComponent<Button>();
        WeaponOptionsbtn.onClick.AddListener(WeaponOptions);

        Button TimeOptionbtn = B_TimeOption.GetComponent<Button>();
        TimeOptionbtn.onClick.AddListener(TimeOption);

        Button ObjectSpoonerbtn = B_ObjectSpooner.GetComponent<Button>();
        ObjectSpoonerbtn.onClick.AddListener(ObjectSpooner);

        Button MiscOptionsbtn = B_MiscOptions.GetComponent<Button>();
        MiscOptionsbtn.onClick.AddListener(MiscOptions);

        Button Homesbtn = B_Home.GetComponent<Button>();
        Homesbtn.onClick.AddListener(Home);

        

    }


    void PlayerStatus()
    {
        A_PlayerStats.SetActive(true);
        Header.text = "Player Status";

        A_PlayerOptions.SetActive(false);
        A_VehicleOptions.SetActive(false);
        A_TeleportOptions.SetActive(false);
        A_WeaponOptions.SetActive(false);
        A_TimeOption.SetActive(false);
        A_ObjectSpooner.SetActive(false);
        A_MiscOptions.SetActive(false);
        A_Home.SetActive(false);
    }

    void PlayerOptions()
    {
        A_PlayerOptions.SetActive(true);
        Header.text = "Player Options";

        A_PlayerStats.SetActive(false);
        A_VehicleOptions.SetActive(false);
        A_TeleportOptions.SetActive(false);
        A_WeaponOptions.SetActive(false);
        A_TimeOption.SetActive(false);
        A_ObjectSpooner.SetActive(false);
        A_MiscOptions.SetActive(false);
        A_Home.SetActive(false);
    }

    void VehicleOptions()
    {
        A_VehicleOptions.SetActive(true);
        Header.text = "Vehicles Options";

        A_PlayerStats.SetActive(false);
        A_PlayerOptions.SetActive(false);
        A_TeleportOptions.SetActive(false);
        A_WeaponOptions.SetActive(false);
        A_TimeOption.SetActive(false);
        A_ObjectSpooner.SetActive(false);
        A_MiscOptions.SetActive(false);
        A_Home.SetActive(false);
    }

    void TeleportOptions()
    {
        A_TeleportOptions.SetActive(true);
        Header.text = "Teleport Options";

        A_PlayerStats.SetActive(false);
        A_PlayerOptions.SetActive(false);
        A_VehicleOptions.SetActive(false);
        A_WeaponOptions.SetActive(false);
        A_TimeOption.SetActive(false);
        A_ObjectSpooner.SetActive(false);
        A_MiscOptions.SetActive(false);
        A_Home.SetActive(false);
    }

    void WeaponOptions()
    {
        A_WeaponOptions.SetActive(true);
        Header.text = "Weapon Options";

        A_PlayerStats.SetActive(false);
        A_PlayerOptions.SetActive(false);
        A_VehicleOptions.SetActive(false);
        A_TeleportOptions.SetActive(false);
        A_TimeOption.SetActive(false);
        A_ObjectSpooner.SetActive(false);
        A_MiscOptions.SetActive(false);
        A_Home.SetActive(false);
    }

    void TimeOption()
    {
        A_TimeOption.SetActive(true);
        Header.text = "Time Options";

        A_PlayerStats.SetActive(false);
        A_PlayerOptions.SetActive(false);
        A_VehicleOptions.SetActive(false);
        A_TeleportOptions.SetActive(false);
        A_WeaponOptions.SetActive(false);
        A_ObjectSpooner.SetActive(false);
        A_MiscOptions.SetActive(false);
        A_Home.SetActive(false);
    }

    void ObjectSpooner()
    {
        A_ObjectSpooner.SetActive(true);
        Header.text = "Object Spooner";

        A_PlayerStats.SetActive(false);
        A_PlayerOptions.SetActive(false);
        A_VehicleOptions.SetActive(false);
        A_TeleportOptions.SetActive(false);
        A_WeaponOptions.SetActive(false);
        A_TimeOption.SetActive(false);
        A_MiscOptions.SetActive(false);
        A_Home.SetActive(false);
    }

    void MiscOptions()
    {
        A_MiscOptions.SetActive(true);
        Header.text = "Misc Option";

        A_PlayerStats.SetActive(false);
        A_PlayerOptions.SetActive(false);
        A_VehicleOptions.SetActive(false);
        A_TeleportOptions.SetActive(false);
        A_WeaponOptions.SetActive(false);
        A_TimeOption.SetActive(false);
        A_ObjectSpooner.SetActive(false);
        A_Home.SetActive(false);
    }

    void Home()
    {
        A_Home.SetActive(true);
        Header.text = "Home";

        A_PlayerStats.SetActive(false);
        A_PlayerOptions.SetActive(false);
        A_VehicleOptions.SetActive(false);
        A_TeleportOptions.SetActive(false);
        A_WeaponOptions.SetActive(false);
        A_TimeOption.SetActive(false);
        A_ObjectSpooner.SetActive(false);
        A_MiscOptions.SetActive(false);
        A_HeadGear.SetActive(false);
        A_Backpack.SetActive(false);
        A_Carrier.SetActive(false);
        A_Lefthand.SetActive(false);
        A_Righthand.SetActive(false);

        // Buttons from Hat Selecetion Script

    }

    // Developer Notes!

    // This grabs the object pages, this is what gets disabled and enabled to show each page
    // A_ is here
    [Header("GameObjects")]
    public GameObject A_PlayerStats;

    [Space(10)]
    public GameObject A_PlayerOptions;
    public GameObject A_HeadGear;
    public GameObject A_Backpack;
    public GameObject A_Carrier;
    public GameObject A_Lefthand;
    public GameObject A_Righthand;

    [Space(10)]
    public GameObject A_VehicleOptions;

    [Space(10)]
    public GameObject A_TeleportOptions;

    [Space(10)]
    public GameObject A_WeaponOptions;

    [Space(10)]
    public GameObject A_TimeOption;

    [Space(10)]
    public GameObject A_ObjectSpooner;

    [Space(10)]
    public GameObject A_MiscOptions;

    [Space(10)]
    public GameObject A_Home;

    [Header("Text Related")]
    public Text Header;

}
