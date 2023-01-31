using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StarterAssets;

public class TeleportLocation : MonoBehaviour
{
    
    public ThirdPersonController Controller;
    public GameObject Player;

   [Header("Locations")]
    public Transform L_XXX;
    public Transform L_BBC;
    public Transform L_HTR;
   

    [Header("Buttons")]
    public Button TP_XXX;
    public Button TP_BBC;
    public Button TP_HTR;



    void Start()
    {
        Button xxxbtn = TP_XXX.GetComponent<Button>();
        xxxbtn.onClick.AddListener(XXX);

        Button bbcbtn = TP_BBC.GetComponent<Button>();
        bbcbtn.onClick.AddListener(BBC);

        Button htrbtn = TP_HTR.GetComponent<Button>();
        htrbtn.onClick.AddListener(HTR);
    }

    void XXX()
    {
        Controller.GetComponent<ThirdPersonController>().enabled = false;
        Player.transform.position = L_XXX.transform.position;
        
    }

    void BBC()
    {
        Controller.GetComponent<ThirdPersonController>().enabled = false;
        Player.transform.position = L_BBC.transform.position;
        
    }

    void HTR()
    {
        Controller.GetComponent<ThirdPersonController>().enabled = false;
        Player.transform.position = L_HTR.transform.position;
    }
}
