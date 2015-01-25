using UnityEngine;
using System.Collections;

public class StartLevelCollision : MonoBehaviour
{
    public GameObject tCamera;
    public ColliderTag EndZoneCollider;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == EndZoneCollider.ToString())
        {
            tCamera.SendMessage("ProceedNextLevel");
            Destroy(gameObject);
        }
        
        if (transform.tag == ColliderTag.StartGame.ToString())
        {
            tCamera.SendMessage("StartGame");
            Destroy(gameObject);
            tCamera.gameObject.GetComponent<WindowsNames>().enabled = true;

        }
    }
}
