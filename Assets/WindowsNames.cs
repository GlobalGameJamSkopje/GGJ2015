using UnityEngine;
using System.Collections;

public class WindowsNames : MonoBehaviour {

    public GUISkin guiSkin;
    public Rect PastPositionRect;
    public Rect PresentPositionRect;
    public Rect FuturePositionRect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUI.skin = guiSkin;
        GUI.Box(new Rect(PastPositionRect.x * Screen.width - (PastPositionRect.width * 0.5f), PastPositionRect.y * Screen.height - (PastPositionRect.height * 0.5f), PastPositionRect.width, PastPositionRect.height), "Past");
        GUI.Box(new Rect(PresentPositionRect.x * Screen.width - (PresentPositionRect.width * 0.5f), PresentPositionRect.y * Screen.height - (PresentPositionRect.height * 0.5f), PresentPositionRect.width, PresentPositionRect.height), "Present");
        GUI.Box(new Rect(FuturePositionRect.x * Screen.width - (FuturePositionRect.width * 0.5f), FuturePositionRect.y * Screen.height - (FuturePositionRect.height * 0.5f), FuturePositionRect.width, FuturePositionRect.height), "Future");
    }
}
