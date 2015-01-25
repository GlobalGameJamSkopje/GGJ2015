using UnityEngine;
using System.Collections;

public class LevelLogic : MonoBehaviour
{
    public GameObject characterPast;
    public GameObject characterPresent;
    public GameObject characterFuture;
    public GUIText TimeLeftPanel;
    public GUIText ScorePanel;
    public AudioClip[] Audio = new AudioClip[6];
    public GameObject[] StartLevels = new GameObject[5];

    private float timeLeft;
    private int currentLevel;

    void Start()
    {
        ScorePanel.enabled = false;
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
        else
        {
            TimeLeftPanel.enabled = false;
            characterPast.SetActive(false);
            characterPresent.SetActive(false);
            characterFuture.SetActive(false);
        }
    }
    void GameOver()
    {
        audio.Stop();

        ScorePanel.text = string.Format("Highest Level (Score): {0} ({1})", GeneralData.HighestLevelScored, GeneralData.Score);
        GeneralData.InGame = false;
        TimeLeftPanel.enabled = false;
        ScorePanel.enabled = true;
    }
    
    void ProceedNextLevel()
    {
        audio.Stop();

        transform.SendMessage("CameraMoveRight");
        GeneralData.Score += (int)timeLeft;
        GeneralData.HighestLevelScored++;
        currentLevel++;
        ResetTimer();

        if (!characterPast.activeInHierarchy)
            characterPast.SetActive(true);

        characterPast.transform.Translate(11, 0, 0);
        characterPresent.transform.Translate(11, 0, 0);
        characterFuture.transform.Translate(11, 0, 0);

        if (currentLevel == 4)
        {
            if (characterFuture.activeInHierarchy)
                characterFuture.SetActive(false);
        }
        if (currentLevel == 5)
        {
            // tuka ja svrte
            TimeLeftPanel.enabled = true;
            ScorePanel.text = string.Format("Highest Level (Score): {0} ({1})", GeneralData.HighestLevelScored, GeneralData.Score);
            ScorePanel.enabled = true;
            GeneralData.InGame = false;            
        }
        else
        {
            StartLevels[currentLevel].collider.enabled = true;
            StartLevels[currentLevel].collider.isTrigger = true;

            audio.clip = Audio[currentLevel + 1];
            audio.Play();
        }        
    }
    void ResetTimer()
    {
        timeLeft = GeneralData.StageTimer;
    }

    void StartGame()
    {
        audio.Stop();

        transform.SendMessage("CameraMoveStart");
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
