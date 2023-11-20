using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamecontroller : MonoBehaviour
{
    private int playerScore = 0;
    private int playerHealth = 100;

    public Text scoreText;
    public Text healthText;


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + playerScore; 
        healthText.text = "Health: " + playerHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncreaseScore(int increaseScoreBy)
    {
        playerScore += increaseScoreBy;
        scoreText.text = "Score: " + playerScore;
        print("IncreaseScore" + playerScore);
    }
}
