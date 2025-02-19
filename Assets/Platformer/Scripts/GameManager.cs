using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    // Start is called before the first frame update
    public TextMeshProUGUI coinText;

    private int score = 0;

    // Method to increment the score
    public void IncrementScore()
    {
        score++;
        coinText.text = "<sprite=0>x " + score.ToString(); 
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int intTime = 160 - (int)Time.realtimeSinceStartup;
        string timeStr = $"Time \n {intTime}";
        timerText.text = timeStr;
    }
}