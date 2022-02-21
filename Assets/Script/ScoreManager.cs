using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //Create instance that allows using this from any script
    public static ScoreManager instance;

    public Text currentScoreText;
    public Text highScoreText;

    int currentScore = 0;
    int highScore = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore", 0);
        currentScoreText.text = "Current score: " + currentScore.ToString();
        highScoreText.text = "High score: " + highScore.ToString();
    }

    public void AddPoints()
    {
        currentScore += 1;
        currentScoreText.text = "Current score: " + currentScore.ToString();

        if (highScore < currentScore)
        PlayerPrefs.SetInt("highScore", currentScore);
    }
}
