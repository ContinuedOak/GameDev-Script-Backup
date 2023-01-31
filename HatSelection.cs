using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HatSelection : MonoBehaviour
{
    public void DropdownSample(int Mask)
    {
        switch (Mask)
        {
            case 0: /*Army();*/
            case 1:
                break;
        }
    }


    [Header("Object")]
    public GameObject A_Army;
    public GameObject A_Football;
    public GameObject A_swat;
    public GameObject A_cowboy;
    public GameObject A_backcap;
    public GameObject A_girlhair;
    public GameObject A_radio;
    public GameObject A_hair;
    public GameObject A_island;
    public GameObject A_randowhair;
    public GameObject A_hunting;
    public GameObject A_linehair;
    public GameObject A_defaultHair;
    public GameObject A_jinx;
    public GameObject A_beard;


    void Army()
    {
        A_Army.SetActive(true);
        Debug.Log("Selected Army Hat!.");

        A_Football.SetActive(false);
        A_swat.SetActive(false);
        A_backcap.SetActive(false);
        A_cowboy.SetActive(false);
        A_girlhair.SetActive(false);
        A_radio.SetActive(false);
        A_hair.SetActive(false);
        A_island.SetActive(false);
        A_randowhair.SetActive(false);
        A_hunting.SetActive(false);
        A_linehair.SetActive(false);
        A_defaultHair.SetActive(false);
        A_linehair.SetActive(false);
        A_jinx.SetActive(false);

    }

    void Football()
    {
        A_Football.SetActive(true);
        Debug.Log("Selected Football Hat!.");

        A_Army.SetActive(false);
        A_swat.SetActive(false);
        A_backcap.SetActive(false);
        A_cowboy.SetActive(false);
        A_girlhair.SetActive(false);
        A_radio.SetActive(false);
        A_hair.SetActive(false);
        A_island.SetActive(false);
        A_randowhair.SetActive(false);
        A_hunting.SetActive(false);
        A_linehair.SetActive(false);
        A_defaultHair.SetActive(false);
        A_linehair.SetActive(false);
        A_jinx.SetActive(false);

    }

    void swat()
    {
        A_swat.SetActive(true);
        Debug.Log("Selected swat Hat!.");

        A_Army.SetActive(false);
        A_Football.SetActive(false);
        A_backcap.SetActive(false);
        A_cowboy.SetActive(false);
        A_girlhair.SetActive(false);
        A_radio.SetActive(false);
        A_hair.SetActive(false);
        A_island.SetActive(false);
        A_randowhair.SetActive(false);
        A_hunting.SetActive(false);
        A_linehair.SetActive(false);
        A_defaultHair.SetActive(false);
        A_linehair.SetActive(false);
        A_jinx.SetActive(false);

    }

    void cowboy()
    {
        A_cowboy.SetActive(true);
        Debug.Log("Selected cowboy Hat!.");

        A_Army.SetActive(false);
        A_swat.SetActive(false);
        A_backcap.SetActive(false);
        A_Football.SetActive(false);
        A_girlhair.SetActive(false);
        A_radio.SetActive(false);
        A_hair.SetActive(false);
        A_island.SetActive(false);
        A_randowhair.SetActive(false);
        A_hunting.SetActive(false);
        A_linehair.SetActive(false);
        A_defaultHair.SetActive(false);
        A_linehair.SetActive(false);
        A_jinx.SetActive(false);

    }

    void backcap()
    {
        A_backcap.SetActive(true);
        Debug.Log("Selected backcap Hat!.");

        A_Army.SetActive(false);
        A_swat.SetActive(false);
        A_Football.SetActive(false);
        A_cowboy.SetActive(false);
        A_girlhair.SetActive(false);
        A_radio.SetActive(false);
        A_hair.SetActive(false);
        A_island.SetActive(false);
        A_randowhair.SetActive(false);
        A_hunting.SetActive(false);
        A_linehair.SetActive(false);
        A_defaultHair.SetActive(false);
        A_linehair.SetActive(false);
        A_jinx.SetActive(false);

    }

    void girlhair()
    {
        A_girlhair.SetActive(true);
        Debug.Log("Selected girlhair Hat!.");

        A_Army.SetActive(false);
        A_swat.SetActive(false);
        A_Football.SetActive(false);
        A_cowboy.SetActive(false);
        A_backcap.SetActive(false);
        A_radio.SetActive(false);
        A_hair.SetActive(false);
        A_island.SetActive(false);
        A_randowhair.SetActive(false);
        A_hunting.SetActive(false);
        A_linehair.SetActive(false);
        A_defaultHair.SetActive(false);
        A_linehair.SetActive(false);
        A_jinx.SetActive(false);

    }

    void radio()
    {
        A_radio.SetActive(true);
        Debug.Log("Selected radio Hat!.");

        A_Army.SetActive(false);
        A_swat.SetActive(false);
        A_Football.SetActive(false);
        A_cowboy.SetActive(false);
        A_girlhair.SetActive(false);
        A_backcap.SetActive(false);
        A_hair.SetActive(false);
        A_island.SetActive(false);
        A_randowhair.SetActive(false);
        A_hunting.SetActive(false);
        A_linehair.SetActive(false);
        A_defaultHair.SetActive(false);
        A_linehair.SetActive(false);
        A_jinx.SetActive(false);

    }

    void hair()
    {
        A_hair.SetActive(true);
        Debug.Log("Selected hair Hat!.");

        A_Army.SetActive(false);
        A_swat.SetActive(false);
        A_Football.SetActive(false);
        A_cowboy.SetActive(false);
        A_girlhair.SetActive(false);
        A_radio.SetActive(false);
        A_backcap.SetActive(false);
        A_island.SetActive(false);
        A_randowhair.SetActive(false);
        A_hunting.SetActive(false);
        A_linehair.SetActive(false);
        A_defaultHair.SetActive(false);
        A_linehair.SetActive(false);
        A_jinx.SetActive(false);

    }

    void island()
    {
        A_island.SetActive(true);
        Debug.Log("Selected island Hat!.");

        A_Army.SetActive(false);
        A_swat.SetActive(false);
        A_Football.SetActive(false);
        A_cowboy.SetActive(false);
        A_girlhair.SetActive(false);
        A_radio.SetActive(false);
        A_hair.SetActive(false);
        A_backcap.SetActive(false);
        A_randowhair.SetActive(false);
        A_hunting.SetActive(false);
        A_linehair.SetActive(false);
        A_defaultHair.SetActive(false);
        A_linehair.SetActive(false);
        A_jinx.SetActive(false);

    }

    void randowhair()
    {
        A_randowhair.SetActive(true);
        Debug.Log("Selected Rainbow Hair Hat!.");

        A_Army.SetActive(false);
        A_swat.SetActive(false);
        A_Football.SetActive(false);
        A_cowboy.SetActive(false);
        A_girlhair.SetActive(false);
        A_radio.SetActive(false);
        A_hair.SetActive(false);
        A_island.SetActive(false);
        A_backcap.SetActive(false);
        A_hunting.SetActive(false);
        A_linehair.SetActive(false);
        A_defaultHair.SetActive(false);
        A_linehair.SetActive(false);
        A_jinx.SetActive(false);

    }

    void hunting()
    {
        A_hunting.SetActive(true);
        Debug.Log("Selected hunting Hat!.");

        A_Army.SetActive(false);
        A_swat.SetActive(false);
        A_Football.SetActive(false);
        A_cowboy.SetActive(false);
        A_girlhair.SetActive(false);
        A_radio.SetActive(false);
        A_hair.SetActive(false);
        A_island.SetActive(false);
        A_randowhair.SetActive(false);
        A_backcap.SetActive(false);
        A_linehair.SetActive(false);
        A_defaultHair.SetActive(false);
        A_linehair.SetActive(false);
        A_jinx.SetActive(false);

    }

    void linehair()
    {
        A_linehair.SetActive(true);
        Debug.Log("Selected linehair Hat!.");

        A_Army.SetActive(false);
        A_swat.SetActive(false);
        A_Football.SetActive(false);
        A_cowboy.SetActive(false);
        A_girlhair.SetActive(false);
        A_radio.SetActive(false);
        A_hair.SetActive(false);
        A_island.SetActive(false);
        A_randowhair.SetActive(false);
        A_hunting.SetActive(false);
        A_backcap.SetActive(false);
        A_defaultHair.SetActive(false);
        A_jinx.SetActive(false);

    }

    void defaultHair()
    {
        A_defaultHair.SetActive(true);
        Debug.Log("Selected defaultHair Hat!.");

        A_Army.SetActive(false);
        A_swat.SetActive(false);
        A_Football.SetActive(false);
        A_cowboy.SetActive(false);
        A_girlhair.SetActive(false);
        A_radio.SetActive(false);
        A_hair.SetActive(false);
        A_island.SetActive(false);
        A_randowhair.SetActive(false);
        A_hunting.SetActive(false);
        A_linehair.SetActive(false);
        A_backcap.SetActive(false);
        A_linehair.SetActive(false);
        A_jinx.SetActive(false);

    }

    void jinx()
    {
        A_jinx.SetActive(true);
        Debug.Log("Selected jinx Hat!.");

        A_Army.SetActive(false);
        A_swat.SetActive(false);
        A_Football.SetActive(false);
        A_cowboy.SetActive(false);
        A_girlhair.SetActive(false);
        A_radio.SetActive(false);
        A_hair.SetActive(false);
        A_island.SetActive(false);
        A_randowhair.SetActive(false);
        A_hunting.SetActive(false);
        A_linehair.SetActive(false);
        A_defaultHair.SetActive(false);
        A_linehair.SetActive(false);
        A_backcap.SetActive(false);

    }

    void beard()
    {
        A_beard.SetActive(true);
        Debug.Log("Selected Beard .");

    }





    void RemoveHat()
    {
        A_backcap.SetActive(false);
        Debug.Log("Selected backcap Hat!.");

        A_Army.SetActive(false);
        A_swat.SetActive(false);
        A_Football.SetActive(false);
        A_cowboy.SetActive(false);
        A_girlhair.SetActive(false);
        A_radio.SetActive(false);
        A_hair.SetActive(false);
        A_island.SetActive(false);
        A_randowhair.SetActive(false);
        A_hunting.SetActive(false);
        A_linehair.SetActive(false);
        A_defaultHair.SetActive(false);
        A_linehair.SetActive(false);
        A_jinx.SetActive(false);

    }
}
