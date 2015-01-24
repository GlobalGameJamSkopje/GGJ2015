using UnityEngine;
using System.Collections;

public class LevelLogic : MonoBehaviour
{

    public GameObject characterPast;
    public GameObject characterPresent;
    public GameObject characterFuture;

    private float timeLeft;
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
        
    }
    void GameOver()
    {
        Debug.Log("GAMEOVER");
    }

    void ProceedNextLevel()
    {
        transform.SendMessage("CameraMoveRight");
    }
    void ResetTimer()
    {
        timeLeft = 60;
    }

}
