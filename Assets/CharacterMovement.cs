using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour
{

    public GameObject characterPast;
    public GameObject characterPresent;
    public GameObject characterFuture;

    private float moveSpeed = 3f;
    private bool canMoveLeft = true;
    private bool canMoveTop = true;
    private bool canMoveRight = true;
    private bool canMoveBot = true;
    void Start()
    {

    }

    void Update()
    {
        if (false) // ova ako testiras da ti se dvizat vo site nasoki idi so true
        {
            characterPast.transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
            characterFuture.transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
            characterPresent.transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
            characterPast.transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
            characterPresent.transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
            characterFuture.transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
        }
        else
        {
            if (Input.GetAxis("Vertical") > 0) //ide nagore
            {
                if (canMoveTop)
                {
                    characterPast.transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
                    characterFuture.transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
                    characterPresent.transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
                }
            }
            else // ide nadole
            {
                if (canMoveBot)
                {
                    characterPast.transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
                    characterFuture.transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
                    characterPresent.transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
                }
            }
            if (Input.GetAxis("Horizontal") > 0) //ide desno
            {
                if (canMoveRight)
                {
                    characterPast.transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
                    characterPresent.transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
                    characterFuture.transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
                }
            }
            else // ide levo
            {
                if (canMoveLeft)
                {
                    characterPast.transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
                    characterPresent.transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
                    characterFuture.transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
                }
            }
        }
        //canMoveLeft = true;
        //canMoveTop = true;
        //canMoveRight = true;
        //canMoveBot = true;

    }
    public void CollisionLeft()
    {
        canMoveLeft = false;
    }
    public void CollisionTop()
    {
        canMoveTop = false;
    }
    public void CollisionRight()
    {
        canMoveRight = false;
    }
    public void CollisionBot()
    {
        canMoveBot = false;
    }
}
