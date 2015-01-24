using UnityEngine;
using System.Collections;

public class LevelLogic : MonoBehaviour {
    
    public GameObject characterPast;
    public GameObject characterPresent;
    public GameObject characterFuture;

	void Start () {
	
	}
	
	void Update () {
	
	}
    void ProceedNextLevel()
    {
        transform.SendMessage("CameraMoveRight");        
    }
}
