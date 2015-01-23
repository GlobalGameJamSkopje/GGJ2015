using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            transform.Translate(new Vector3(-11, 0, 0));
        if (Input.GetButtonDown("Fire2"))
            transform.Translate(new Vector3(11, 0, 0));
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(new Vector3(-1, 0, 0));
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(new Vector3(1, 0, 0));
        //if (Input.GetKey(KeyCode.LeftArrow))
        //    transform.position = Vector3.Lerp(transform.position, transform.position + new Vector3(10, 0, 0), 0.15f);
        //if (Input.GetKey(KeyCode.RightArrow))
        //    transform.Translate(new Vector3(1, 0, 0));
    }
}
