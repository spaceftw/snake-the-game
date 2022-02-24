using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text scoreText;
    public void Setup(int currentScore)
    {
        gameObject.SetActive(true);
        scoreText.text = "YOUR SCORE: " + currentScore.ToString();
    }


}
