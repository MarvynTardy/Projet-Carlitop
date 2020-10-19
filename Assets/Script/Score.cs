using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float scoreVal;
    public float scorePerSec;
    Text score;

    private void Start()
    {
        score = GetComponent<Text>();
        scoreVal = 1f;
        scorePerSec = 10f;
}

    private void Update()
    {
        
        score.text = " : " + (int)scoreVal;
        scoreVal += scorePerSec * Time.deltaTime;
    }
}
