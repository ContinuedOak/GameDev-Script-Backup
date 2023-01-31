using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class DevMenuOpen : MonoBehaviour
{
    public ThirdPersonShooterController aim;
    public GameObject DevMenu;
    public bool OpenMenu;
    public StarterAssetsInputs Asset;

    void Start()
    {
        OpenMenu = true;
        DevMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F8))
        {
            
            OpenMenu = !OpenMenu;
            if (OpenMenu)
            {
                DevMenu.SetActive(false);
                Debug.Log("Menu Closed!.");
                Asset.cursorInputForLook = true;
                aim.canAim = true;
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                Debug.Log("Menu Opened!.");
                Asset.cursorInputForLook = false;
                DevMenu.SetActive(true);
                aim.canAim = false;
                Cursor.lockState = CursorLockMode.None;
            }
        }

    }
}
