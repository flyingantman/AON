using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioClip))]
public class PlayerShifter : MonoBehaviour
{

    public AudioClip switching;


    //AudioClip audio;
    public GameObject TriangleTransformer, SquareTransformer, CircleTransformer;
    public Sprite circle, triangle, square;
    public GameObject PlayerCircle, PlayerTriangle, PlayerSquare;
    private PolygonCollider2D circleCollider, triangleCollider, squareCollider;
    // Use this for initialization
    void Start()
    {
        GetComponent<AudioClip>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "SquareTransformer")
        {
            print("square");
            gameObject.tag = "SquarePlayer";
            gameObject.layer = 13;
            GetComponent<SpriteRenderer>().sprite = square;
            AudioSource.PlayClipAtPoint(switching, SquareTransformer.transform.position);
        }
        if (coll.gameObject.tag == "TriangleTransformer")
        {

            print("triangle");
            gameObject.tag = "TrianglePlayer";
            gameObject.layer = 14;
            GetComponent<SpriteRenderer>().sprite = triangle;
            AudioSource.PlayClipAtPoint(switching, TriangleTransformer.transform.position);
        }
        if (coll.gameObject.tag == "CircleTransformer")
        {

            print("circle");
            gameObject.tag = "CirclePlayer";
            gameObject.layer = 15;
            GetComponent<SpriteRenderer>().sprite = circle;
            AudioSource.PlayClipAtPoint(switching, CircleTransformer.transform.position);
        }
    }
}
