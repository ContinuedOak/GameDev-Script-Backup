using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevMenuMaskDrop : MonoBehaviour
{
    public GameObject A_GasMask;
    public GameObject A_SmileyMask;
    public GameObject A_Hockey;
    public GameObject A_VRheadset;
    public GameObject A_RichVR;


    public void DropdownSample(int Mask)
    {
        switch (Mask)
        {
            case 0: Nothing(); break;
            case 1: GasMask(); break;
            case 2: SmileyMask(); break;
            case 3: Hockey(); break;
            case 4: VRheadset(); break;
            case 5: RichVR(); break;

        }
    }

    void Nothing()
    {
        A_GasMask.SetActive(false);
        A_Hockey.SetActive(false);
        A_VRheadset.SetActive(false);
        A_RichVR.SetActive(false);
        A_SmileyMask.SetActive(false);
    }

    void GasMask()
    {
        Nothing();
        A_GasMask.SetActive(true);
    }
    
    void SmileyMask()
    {
        Nothing();
        A_SmileyMask.SetActive(true);
    }
    
    void Hockey()
    {
        Nothing();
        A_Hockey.SetActive(true);
    }   
    
    void VRheadset()
    {
        Nothing();
        A_VRheadset.SetActive(true);
    }    
    
    void RichVR()
    {
        Nothing();
        A_RichVR.SetActive(true);
    }
}
