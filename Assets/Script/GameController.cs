using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{


    public GameOverScreen GameOverScreen;
    int currentScore;



    public void GameOver()
    {
        GameOverScreen.Setup(currentScore);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<GameController>().GameOver();
        }
    }

}
