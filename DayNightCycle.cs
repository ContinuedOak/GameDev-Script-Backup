using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
     [Header("Day & Night Cycle")]
    [Tooltip("Can the Time Pass?")] public bool doDayCycle;
    public bool isNight;

    [Tooltip("How long the in-game time is in real world minutes (Default = 15f)")] public float dayLengthInMinutes = 1f;
    [Tooltip("How fast the sun rotates")] public float rotationSpeed = 1f;
    public float currentRotation = 0f;
    [Tooltip("Current Day Counter (Default Start = 0)")] public float currentDay = 0f;

    void Update()
    {
        if (doDayCycle)
        {
            float anglePerFrame = Time.deltaTime * (360f / (dayLengthInMinutes * 60f));
            transform.Rotate(Vector3.right, anglePerFrame * rotationSpeed);
            currentRotation += anglePerFrame * rotationSpeed;
            if (currentRotation >= 360f)
            {
                currentRotation -= 360f;
                currentDay++;
            }


            // Turns off Lights if Night Time


            if (currentRotation >= 133f && currentRotation <= 312f)
            {
                isNight = true;
            }
            else
            {
                isNight = false;
            }

            Light light = GetComponent<Light>();
            light.enabled = !isNight;
        }
    }
}
