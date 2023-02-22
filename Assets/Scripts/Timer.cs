using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text displayText = null;
    public float value;

    // Update is called once per frame
    void Update()
    {
        if (displayText != null)
        {
            displayText.text = "Time: " + (int)(value += Time.deltaTime);
        }
    }
}
