using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class PlayerManager : MonoBehaviour
{
    [Header("Player Manager")]
    [Tooltip("Set/View the players Health")][Range(0, 100)] public int health;
    [Tooltip("Change the Cameras FOV")][Range(10,100)] public float fov;
    [Tooltip("Change the Cameras FOV")][Range(10,100)] public float privateFOV;
    public float fovTarget = 30f;
    public float fovSpeed = 1f;
    public float currentFOV;

    [Header("Player Imporant")]
    [Tooltip("if true the player can walk")] public bool canWalk;
    [Tooltip("if trie the player can sprint")] public bool canSprint;
    [Tooltip("if true the player is able to jump (doesnt effect gravity)")] public bool canJump;
    [Tooltip("if true the player is able to look around)")] public bool canLookAround;

    [Header("Player Cheats")]
    [Tooltip("Used to turn on all developer settings")] public bool developerMode; // Dev Stuff ONLY
    [Tooltip("Used to turn on all debug settings")] public bool debugMode; // Debugging Stuff ONLY
    [Tooltip("")] public bool superJump;
    [Tooltip("")] public bool speedyRun;

    [Header("CameraSettings")]
    public CinemachineVirtualCamera virtualCamera;

    [Header("Debug Cheats")]
    [Tooltip("Open/Close the Debugscreen")] public KeyCode openDebugScreen;
    [Tooltip("Open/Close the ConsoleLog")] public KeyCode openConsole;
    [Tooltip("Open/Close the CommandLog")] public KeyCode openCommands;

    [Header("Player Checks")]
    [Tooltip("")] public bool isWalking;
    [Tooltip("")] public bool isRunning;
    [Tooltip("")] public bool isFalling;
    public float walkAmplitudeGain = 1f;
    public float walkFrequencyGainValue = 1f;
    public float runAmplitudeGain = 3f;
    public float runFrequencyGainValue = 3f;
    public float idleAmplitudeGain = 1f;
    public float idleFrequencyGainValue = 1f;

    [Header("UI Manager")]
    public GameObject crossHair;
    [Range(0,5)] public float crosshairSize;

    #region Unity
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        virtualCamera.m_Lens.FieldOfView = fov;
        ResizeObject();
         
        if (isWalking)
        {
            if(!isRunning)
            {
                isWalkingState();
            }
            else
            {
                isRunningState();
            }
        }
        else
        {
            isIdleState();
        }
    }
    #endregion
    void isIdleState()
    {
        // Change Camera Shake
        CinemachineBasicMultiChannelPerlin noise = virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        noise.m_AmplitudeGain = idleAmplitudeGain;
        noise.m_FrequencyGain = idleFrequencyGainValue;

    }

    void isWalkingState()
    {
        // Change Camera Shake
        CinemachineBasicMultiChannelPerlin noise = virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        noise.m_AmplitudeGain = walkAmplitudeGain;
        noise.m_FrequencyGain = walkFrequencyGainValue;

    }

    void isRunningState()
    {
        // Change Camera Shake
        CinemachineBasicMultiChannelPerlin noise = virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        noise.m_AmplitudeGain = runAmplitudeGain;
        noise.m_FrequencyGain = runFrequencyGainValue;

    }

    void ResizeObject()
    {
        crossHair.transform.localScale = new Vector3(crosshairSize, crosshairSize, crosshairSize);
    }
}
