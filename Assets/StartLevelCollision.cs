using UnityEngine;
using System.Collections;

public class StartLevelCollision : MonoBehaviour
{
    public GameObject tCamera;
    public ColliderTag EndZoneCollider;

    void Start()
    {

    }

    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == EndZoneCollider.ToString())
        {
            tCamera.SendMessage("ProceedNextLevel");
        }
    }
}
