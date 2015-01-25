using UnityEngine;
using System.Collections;

public class CharacterCollision : MonoBehaviour
{
    public GameObject tCamera;
    
    void OnCollisionEnter(Collision collision)
    {
        bool left = collision.contacts[0].normal == Vector3.right;//contactPoint.x > center.x;
        bool right = collision.contacts[0].normal == Vector3.left;//contactPoint.x < center.x;
        bool bot = collision.contacts[0].normal == Vector3.up;//contactPoint.y > center.y;
        bool top = collision.contacts[0].normal == Vector3.down;//contactPoint.y < center.y;
        Log.CharacterCollisionAxes(left, right, bot, top);

        if (left)
        {
            Log.CharacterCollisionSide(Direction.Left);
            tCamera.SendMessage("CollisionLeft");
        }
        if (top)
        {
            Log.CharacterCollisionSide(Direction.Top);
            tCamera.SendMessage("CollisionTop");
        }
        if (bot)
        {
            Log.CharacterCollisionSide(Direction.Bot);
            tCamera.SendMessage("CollisionBot");
        }
        if (right)
        {
            Log.CharacterCollisionSide(Direction.Right);
            tCamera.SendMessage("CollisionRight");
        }
    }
    
}
