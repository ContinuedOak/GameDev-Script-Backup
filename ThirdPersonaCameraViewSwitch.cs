using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using StarterAssets;

public class ThirdPersonaCameraViewSwitch : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera ViewClose;
    [SerializeField] private CinemachineVirtualCamera ViewNormal;
    [SerializeField] private CinemachineVirtualCamera ViewFar;

    private bool isCamClose;
    private bool isCamNormal = true;
    private bool isCamFar;

    private StarterAssetsInputs starterAssetsInputs;
    private void Awake()
    {
        starterAssetsInputs = GetComponent<StarterAssetsInputs>();
    }

    private void Update()
    {
        if (starterAssetsInputs.cameraview)
        {
            if (isCamClose)
            {
                ViewFar.gameObject.SetActive(false);
                ViewNormal.gameObject.SetActive(true);
               
            }
            else if (isCamNormal)
            {
                ViewClose.gameObject.SetActive(false);
                ViewFar.gameObject.SetActive(true);
                
            }
            else if (isCamFar)
            {
                ViewNormal.gameObject.SetActive(false);
                ViewClose.gameObject.SetActive(true);
                
            }
        }
    }

}
