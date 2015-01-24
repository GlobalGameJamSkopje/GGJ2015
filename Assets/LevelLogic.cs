using UnityEngine;
using System.Collections;

public class LevelLogic : MonoBehaviour
{

    public GameObject characterPast;
    public GameObject characterPresent;
    public GameObject characterFuture;
    public GUIText TimeLeftPanel;

    private float timeLeft = 5;
    void Start()
    {

    }

    void Update()
    {
        if (GeneralData.InGame)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                GameOver();
            }
        }
        TimeLeftPanel.text = "Time Left: " + ((int)timeLeft).ToString();        
    }
    void GameOver()
    {
        Debug.Log("GAMEOVER");
        GeneralData.InGame = false;
    }

    void ProceedNextLevel()
    {
        transform.SendMessage("CameraMoveRight");
        ResetTimer();
        GeneralData.Score += (int)timeLeft;
        GeneralData.HighestLevelScored++;
    }
    void ResetTimer()
    {
        timeLeft = 60;
    }

}
