using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{

    public Text pointsText;
    public void Setup(int currentScore)
    {
        gameObject.SetActive(true);
        pointsText.text = "YOUR SCORE: " + currentScore.ToString();
    }


}
