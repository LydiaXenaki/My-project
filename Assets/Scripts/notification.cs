using System;
using UnityEngine;
using System.Collections;

public class notification : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Reference to the GameObject to enable
    public GameObject objectToEnable;

    // Time to wait before enabling the GameObject
    public float delayInSeconds = 5;
    void Start()
    {
        StartCoroutine(EnableObjectAfterDelay());

    }

    IEnumerator EnableObjectAfterDelay()
    {
        // Wait for the specified amount of time
        yield return new WaitForSeconds(delayInSeconds);

        // Enable the GameObject
        objectToEnable.SetActive(true);
    }

   
}
