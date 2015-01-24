﻿using UnityEngine;
using System.Collections;

public class ScreenSize : MonoBehaviour
{

    public GUIText Past;
    public GUIText Present;
    public GUIText Future;
    public GUIText Time;
    public GUISkin guiSkin;
    public Rect PastPositionRect;
    public Rect PresentPositionRect;
    public Rect FuturePositionRect;


    void Start()
    {
        Camera.main.orthographicSize = 16.5f / Screen.width * Screen.height;
       
        
    }

    void Update()
    {
        Camera.main.orthographicSize = 16.5f / Screen.width * Screen.height;
    }

    void OnGUI()
    {
        GUI.skin = guiSkin;
        GUI.Box(new Rect(PastPositionRect.x * Screen.width - (PastPositionRect.width * 0.5f), PastPositionRect.y * Screen.height - (PastPositionRect.height * 0.5f), PastPositionRect.width, PastPositionRect.height), "Past");
        GUI.Box(new Rect(PresentPositionRect.x * Screen.width - (PresentPositionRect.width * 0.5f), PresentPositionRect.y * Screen.height - (PresentPositionRect.height * 0.5f), PresentPositionRect.width, PresentPositionRect.height), "Present");
        GUI.Box(new Rect(FuturePositionRect.x * Screen.width - (FuturePositionRect.width * 0.5f), FuturePositionRect.y * Screen.height - (FuturePositionRect.height * 0.5f), FuturePositionRect.width, FuturePositionRect.height), "Future");
    }
}
