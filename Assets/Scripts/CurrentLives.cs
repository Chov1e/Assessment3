using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentLives : MonoBehaviour
{
    public Text livesText;
    public static int LivesCurrent;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives: " + LivesCurrent.ToString();
    }
}

