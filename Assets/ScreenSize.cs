using UnityEngine;
using System.Collections;

public class ScreenSize : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Camera.main.orthographicSize = 16.5f / Screen.width * Screen.height;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
