using UnityEngine;
using System.Collections;

public class LevelLogic : MonoBehaviour
{
    public GameObject characterPast;
    public GameObject characterPresent;
    public GameObject characterFuture;
    public GUIText TimeLeftPanel;
    public AudioClip[] Audio = new AudioClip[6];
    public GameObject[] StartLevels = new GameObject[5];

    private float timeLeft;
    private int currentLevel;

    void Start()
    {
        TimeLeftPanel.enabled = false;
        characterPast.SetActive(false);
        characterPresent.SetActive(false);
        characterFuture.SetActive(false);
    }

    void Update()
    {
        if (GeneralData.InGame)
        {
            TimeLeftPanel.enabled = true;
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                GameOver();
            }
            TimeLeftPanel.text = "Time Left: " + ((int)timeLeft).ToString();        
        }      
    }
    void GameOver()
    {
        audio.Stop();

        Debug.Log("GAMEOVER");
        GeneralData.InGame = false;
        TimeLeftPanel.enabled = false;
        
    }
    
    void ProceedNextLevel()
    {
        audio.Stop();

        transform.SendMessage("CameraMoveRight");
        ResetTimer();
        GeneralData.Score += (int)timeLeft;
        GeneralData.HighestLevelScored++;
        currentLevel++;
        StartLevels[currentLevel].collider.enabled = true;
        StartLevels[currentLevel].collider.isTrigger = true;

        if (!characterPast.activeInHierarchy)
            characterPast.SetActive(true);

        characterPast.transform.Translate(11, 0, 0);
        characterPresent.transform.Translate(11, 0, 0);
        characterFuture.transform.Translate(11, 0, 0);

        audio.clip = Audio[currentLevel+1];
        audio.Play();
    }
    void ResetTimer()
    {
        timeLeft = GeneralData.StageTimer;
    }

    void StartGame()
    {
        audio.Stop();

        GeneralData.InGame = true;
        GeneralData.Score = 0;
        GeneralData.HighestLevelScored = 0;
        TimeLeftPanel.enabled = true;
        currentLevel = 0;
        timeLeft = GeneralData.StageTimer;
        StartLevels[currentLevel].collider.enabled = true;
        StartLevels[currentLevel].collider.isTrigger = true;

        characterPresent.SetActive(true);
        characterFuture.SetActive(true);

        audio.clip = Audio[currentLevel+1];
        audio.Play();
    }
}
