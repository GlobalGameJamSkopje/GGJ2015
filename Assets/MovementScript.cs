using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour
{

    private float moveSpeed = 3f;

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);        
    }
}