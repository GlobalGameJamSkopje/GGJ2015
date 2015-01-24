using UnityEngine;
using System.Collections;

public class Log
{
    private static bool DoLoging = false;
    public static void CharacterCollisionAxes(bool left, bool right, bool bot, bool top)
    {
        if (DoLoging)
            Debug.Log(" left: " + left + " right: " + right + " bot: " + bot + " top: " + top);
    }
    public static void CharacterCollisionSide(Direction direction)
    {
        if (DoLoging)
        {
            switch (direction)
            {
                case Direction.Bot:
                    Debug.Log("The object is to the Bot");
                    break;
                case Direction.Top:
                    Debug.Log("The object is to the Top");
                    break;
                case Direction.Left:
                    Debug.Log("The object is to the Left");
                    break;
                case Direction.Right:
                    Debug.Log("The object is to the Right");
                    break;
            }
        }
    }
}

public class GeneralData
{
    public static int Score;
    public static int HighestLevelScored;

    public static bool InGame = true;
}