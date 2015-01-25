using UnityEngine;
using System.Collections;

public class ShapeTransformation : MonoBehaviour {
    public GameObject CharacterPast;
    public GameObject CharacterPresent;
    public GameObject CharacterFuture;
    public ColliderTag ToShape;
    public Texture ToTexture;

    void OnTriggerEnter(Collider other)
    {
        CharacterPast.renderer.material.mainTexture = ToTexture;
        CharacterPresent.renderer.material.mainTexture = ToTexture;
        CharacterFuture.renderer.material.mainTexture = ToTexture;
        CharacterPresent.tag = ToShape.ToString();
        Destroy(gameObject);
    }
}
