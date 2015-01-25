using UnityEngine;
using System.Collections;

public class LeverCollision : MonoBehaviour {

    public GameObject ObjectToDestroy;
    public GameObject CharacterPast;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == CharacterPast)
        {
            Destroy(gameObject);
            Destroy(ObjectToDestroy);
        }        
    }
}
