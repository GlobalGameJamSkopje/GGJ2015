using UnityEngine;
using System.Collections;

public class ShapeTransformation : MonoBehaviour {
    public GameObject CharacterPresent;
    public ColliderTag ToShape;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("ShapeTransformation");
        CharacterPresent.tag = ToShape.ToString();
        Destroy(gameObject);
    }
}
