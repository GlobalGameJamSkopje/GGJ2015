using UnityEngine;
using System.Collections;

public class MovableScriptLevel4 : MonoBehaviour
{
    public GameObject CharacterPast;
    public GameObject CharacterPresent;
    private int pastMoved;
    private int presentMoved;

    void Start()
    {
        presentMoved = 0;
        pastMoved = 0;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == CharacterPast)
        {
            if (pastMoved < 1)
            {
                gameObject.transform.Translate(+0.7f, 0, 0);
                pastMoved++;
            }
        }
        if (collision.gameObject == CharacterPresent)
        {
            if (presentMoved < 3)
            {
                gameObject.transform.Translate(-0.7f, 0, 0);
                presentMoved++;
            }
        }        
    }
}
