using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager singleton;
    public int best;
    public int score;
    public int currentStage = 0;
   
    private void Awake()
    {
        if (singleton == null)
            singleton = this;
        else if (singleton != this)
            Destroy(gameObject);
        best = PlayerPrefs.GetInt("Highscore"); //извлечение сохраненного результата
    }

    public void NextLevel()
    {
        currentStage++;
        FindObjectOfType<BallController>().ResetBall();
        FindObjectOfType<HelixController>().LoadStage(currentStage);
    }

    public void RestartLevel()
    {
        Debug.Log("Restarting Level");
        singleton.score = 0;
        FindObjectOfType<BallController>().ResetBall();//вызов метода перезагрузки уровня из класса BallController
        FindObjectOfType<HelixController>().LoadStage(currentStage);
    }

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;

        if (score > best)
        {
            best = score;
            PlayerPrefs.SetInt("Highscore", score);// хранение результата
        }
    }


}
