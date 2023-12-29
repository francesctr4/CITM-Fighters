using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AzriScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int scoreValue;


    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Azri Score: " + scoreValue;
    }

}

