using UnityEngine;
using System.Collections;

public class StartLevelCollision : MonoBehaviour
{
    public GameObject tCamera;
    public ColliderTag EndZoneCollider;
    public GameObject DestroyFutureStartPositionLevelObject;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == EndZoneCollider.ToString())
        {
            tCamera.SendMessage("ProceedNextLevel");
            Destroy(gameObject);
            
            if (DestroyFutureStartPositionLevelObject != null)
                Destroy(DestroyFutureStartPositionLevelObject);
        }
        
        if (transform.tag == ColliderTag.StartGame.ToString())
        {
            tCamera.SendMessage("StartGame");
            Destroy(gameObject);
            tCamera.gameObject.GetComponent<WindowsName>().enabled = true;

        }
    }
}
