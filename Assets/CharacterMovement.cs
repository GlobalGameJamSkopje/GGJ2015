using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour
{
    public GameObject characterPast;
    public GameObject characterPresent;
    public GameObject characterFuture;

    private Direction currentDirection;
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
        if (!GeneralData.InGame)
            return;

        if (Input.GetAxis("Vertical") > 0)
            currentDirection = Direction.Top;
        if (Input.GetAxis("Vertical") < 0)
            currentDirection = Direction.Bot;
        if (Input.GetAxis("Horizontal") < 0)
            currentDirection = Direction.Left;
        if (Input.GetAxis("Horizontal") > 0)
            currentDirection = Direction.Right;

        switch (currentDirection)
        {
            case Direction.Top:
                if (canMoveTop)
                {
                    characterPast.transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
                    characterFuture.transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
                    characterPresent.transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
                    canMoveRight = true;
                    canMoveLeft = true;
                    canMoveBot = true;
                }
                break;
            case Direction.Bot:
                if (canMoveBot)
                {
                    characterPast.transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
                    characterFuture.transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
                    characterPresent.transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
                    canMoveRight = true;
                    canMoveLeft = true;
                    canMoveTop = true;
                }
                break;
            case Direction.Left:
                if (canMoveLeft)
                {
                    characterPast.transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
                    characterPresent.transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
                    characterFuture.transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
                    canMoveRight = true;
                    canMoveTop = true;
                    canMoveBot = true;
                }
                break;
            case Direction.Right:
                if (canMoveRight)
                {
                    characterPast.transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
                    characterPresent.transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
                    characterFuture.transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
                    canMoveLeft = true;
                    canMoveTop = true;
                    canMoveBot = true;
                }
                break;
        }
        currentDirection = Direction.None;
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
