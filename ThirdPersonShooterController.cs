using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
using StarterAssets;

public class ThirdPersonShooterController : MonoBehaviour
{

    [SerializeField] private CinemachineVirtualCamera aimVirtualCamera;
    [SerializeField] private float normalSensitivity;
    [SerializeField] private float aimSensitivity;
    [SerializeField] private LayerMask aimColliderMask = new LayerMask();
    [SerializeField] private Transform debugTransform;
    [SerializeField] private Transform pfBulletProjectial;
    [SerializeField] private Transform BulletSpawnPoint;
    public bool canAim = true;

    private StarterAssetsInputs starterAssetsInputs;
    private ThirdPersonController thirdPersonController;


    private void Awake()
    {
        thirdPersonController = GetComponent<ThirdPersonController>();
        starterAssetsInputs = GetComponent<StarterAssetsInputs>();
        aimVirtualCamera.gameObject.SetActive(false);
    }

    private void Update()
    {
        Vector3 mouseWorldPosition = Vector3.zero;
        Vector2 screenCenterPoint = new Vector2(Screen.width / 2f, Screen.height / 2f);
        Ray ray = Camera.main.ScreenPointToRay(screenCenterPoint);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, 999f, aimColliderMask))
        {
            debugTransform.transform.position = raycastHit.point;
            mouseWorldPosition = raycastHit.point;
        }

        if (canAim)
        {
            if (starterAssetsInputs.aim)
            {
                thirdPersonController.SetSensitivity(aimSensitivity);
                aimVirtualCamera.gameObject.SetActive(true);
                thirdPersonController.SetRotateOnMove(false);

                Vector3 worldAimTarget = mouseWorldPosition;
                mouseWorldPosition.y = transform.position.y;
                Vector3 aimDirection = (worldAimTarget - transform.position).normalized;
                starterAssetsInputs.sprint = false;

                transform.forward = Vector3.Lerp(transform.forward, aimDirection, Time.deltaTime * 20f);

            }
            else
            {
                thirdPersonController.SetSensitivity(normalSensitivity);
                aimVirtualCamera.gameObject.SetActive(false);
                thirdPersonController.SetRotateOnMove(true);
            
            }

        if (starterAssetsInputs.shoot)
        {
            Vector3 aimDir = (mouseWorldPosition - BulletSpawnPoint.position).normalized;
            Instantiate(pfBulletProjectial, BulletSpawnPoint.position, Quaternion.LookRotation(aimDir, Vector3.up));
            
        }
        }
    }
}

