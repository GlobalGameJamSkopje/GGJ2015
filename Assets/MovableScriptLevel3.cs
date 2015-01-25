using UnityEngine;
using System.Collections;

public class MovableScriptLevel3 : MonoBehaviour
{

    public GameObject CharacterPast;
    private bool isMoved = false;
    
    void OnCollisionEnter(Collision collision)
    {
        if (!isMoved)
        {
            if (collision.gameObject == CharacterPast)
            {
                gameObject.transform.Translate(-0.7f, 0, 0);
                isMoved = true;
            }            
        }
    }
}
