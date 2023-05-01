using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public float dayLengthInMinutes = 1f;
    public float rotationSpeed = 1f;
    public float currentRotation = 0f;
    public float currentDay = 1f;

    void Update()
    {
        float anglePerFrame = Time.deltaTime * (360f / (dayLengthInMinutes * 60f));
        transform.Rotate(Vector3.right, anglePerFrame * rotationSpeed);
        currentRotation += anglePerFrame * rotationSpeed;
        if (currentRotation >= 360f)
        {
            currentRotation -= 360f;
            currentDay++;
        }
    }
}
