using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 endPositionLeft;
    private Vector3 endPositionRight;
    private float endZoomRight;
    private float endZoomRight1;
    private float endZoomLeft;
    private float endZoomLeft1;
    private bool rotateLeft;
    private bool rotateRight;

    void Start()
    {

    }

    void Update()
    {
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    startPosition = transform.position;
        //    endPositionLeft = startPosition + new Vector3(-11, 0, 0);
        //    endZoomLeft = Camera.main.orthographicSize + 9;
        //    endZoomLeft1 = Camera.main.orthographicSize;
        //    rotateLeft = true;
        //}

        //if (Input.GetButtonDown("Fire2"))
        //{
        //    startPosition = transform.position;
        //    endPositionRight = startPosition + new Vector3(11, 0, 0);
        //    endZoomRight = Camera.main.orthographicSize+9;
        //    endZoomRight1 = Camera.main.orthographicSize;
        //    rotateRight = true;
        //}

        if (transform.position != endPositionLeft && rotateLeft)
        {
            transform.position = Vector3.Lerp(transform.position, endPositionLeft, 10f * Time.deltaTime);

            if (Mathf.Abs(transform.position.x - endPositionLeft.x) >= 5)
                Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, endZoomLeft, 10f * Time.deltaTime);
            else
                Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, endZoomLeft1, 10f * Time.deltaTime);

            if (transform.position == endPositionLeft)
                rotateLeft = false;
        }
        else if (transform.position != endPositionRight && rotateRight)
        {
            transform.position = Vector3.Lerp(transform.position, endPositionRight, 10f * Time.deltaTime);

            if (Mathf.Abs(transform.position.x - endPositionRight.x) >= 5)
                Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, endZoomRight, 10f * Time.deltaTime);
            else
                Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, endZoomRight1, 10f * Time.deltaTime);

            if (transform.position == endPositionRight)
                rotateRight = false;
        }
    }
    void CameraMoveLeft()
    {
        if (rotateLeft || rotateRight)
            return;

        startPosition = transform.position;
        endPositionLeft = startPosition + new Vector3(-11, 0, 0);
        endZoomLeft = Camera.main.orthographicSize + 9;
        endZoomLeft1 = Camera.main.orthographicSize;
        rotateLeft = true;
    }
    void CameraMoveRight()
    {
        if (rotateLeft || rotateRight)
            return;

        startPosition = transform.position;
        endPositionRight = startPosition + new Vector3(11, 0, 0);
        endZoomRight = Camera.main.orthographicSize + 9;
        endZoomRight1 = Camera.main.orthographicSize;
        rotateRight = true;
    }
}
