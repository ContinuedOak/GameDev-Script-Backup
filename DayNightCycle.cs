using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day & Night Cycle")]
     [Header("v3.0")]
    [Tooltip("Can the Time Pass?")] public bool doDayCycle;
    public bool isNight;

    [Tooltip("How long the in-game time is in real world minutes (Default = 15f)")] public float dayLengthInMinutes = 1f;
    [Tooltip("How fast the sun rotates")] public float rotationSpeed = 1f;
    public float currentRotation = 0f;
    [Tooltip("Current Day Counter (Default Start = 0)")] public float currentDay = 0f;

    public Light lightObject; // Reference to the light object

    // Define the night color for the light object
    public Color nightColor = Color.blue;

    private Color originalColor; // Original color of the light object

    void Start()
    {
        lightObject = GetComponent<Light>();
        // Store the original color of the light object
        originalColor = lightObject.color;
    }

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
            if (currentRotation >= 120f && currentRotation <= 300f)
            {
                isNight = true;

                // Set the light object color to night color
                lightObject.color = nightColor;
            }
            else
            {
                isNight = false;

                // Reset the light object color to original color
                lightObject.color = originalColor;
            }
        }
    }
}
// Script by ContinuedOak
