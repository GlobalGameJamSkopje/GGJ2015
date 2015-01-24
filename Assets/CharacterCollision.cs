using UnityEngine;
using System.Collections;

public class CharacterCollision : MonoBehaviour
{
    public GameObject tCamera;
    void Start()
    {

    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        var collider = collision.collider;

        Vector3 contactPoint = collision.contacts[0].point;
        Vector3 center = collider.bounds.center;

        bool left = collision.contacts[0].normal == Vector3.right;//contactPoint.x > center.x;
        bool right = collision.contacts[0].normal == Vector3.left;//contactPoint.x < center.x;
        bool bot = collision.contacts[0].normal == Vector3.up;//contactPoint.y > center.y;
        bool top = collision.contacts[0].normal == Vector3.down;//contactPoint.y < center.y;
        Debug.Log(" left: " + left + " right: " + right + " bot: " + bot + " top: " + top);
        
        if (left)
        {
            Debug.Log("The object is to the left");
            tCamera.SendMessage("CollisionLeft");
        }
        if (top)
        {
            Debug.Log("The object is to the top");
            tCamera.SendMessage("CollisionTop");
        }
        if (bot)
        {
            Debug.Log("The object is to the bot");
            tCamera.SendMessage("CollisionBot");
        }
        if (right)
        {
            Debug.Log("The object is to the right");
            tCamera.SendMessage("CollisionRight");            
        }
    }
}
