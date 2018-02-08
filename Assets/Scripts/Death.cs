using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour
{
    public int player;
    private int deathcount;
    private bool dying, onepick;

    public string input1 = "square", input2 = "circle", input3 = "triangle";
    public Sprite circle, triangle, square;
    public GameObject PlayerCircle, PlayerTriangle, PlayerSquare;
    //private bool invuln;
    // Use this for initialization
    void Start()
    {
        onepick = false;
        deathcount = 0;
        dying = false;

        if (player == 2)
        {
            input1 = "square-2";
            input2 = "circle-2";
            input3 = "triangle-2";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (onepick)
        {
            Revive();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            dying = true;
            die();
        }

        if (dying)
        {
            GetComponent<Movement>().enabled = false;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "CircleBullet" && gameObject.tag == "TrianglePlayer")
        {
            print("circle kills triangle");
            dying = true;
            die();
            //Destroy(this.gameObject);
        }
        if (coll.gameObject.tag == "SquareBullet" && gameObject.tag == "CirclePlayer")
        {
            print("square kills circle");
            dying = true;
            die();
            //Destroy(this.gameObject);
        }
        if (coll.gameObject.tag == "TriangleBullet" && gameObject.tag == "SquarePlayer")
        {
            print("triangle kills square");
            dying = true;
            die();
            //Destroy(this.gameObject);
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.2f);
        dying = false;
    }
    /*IEnumerator waitres()
    {
        yield return new WaitForSeconds(1.6f);
        dying = false;
        GetComponent<Movement>().enabled = true;
    }*/



    void die()
    {
        deathcount++;
        StartCoroutine(wait());
        onepick = true;
    }

    void Revive()
    {

        if (Input.GetButton(input1))
        {

            gameObject.tag = "SquarePlayer";
            gameObject.layer = 13;
            GetComponent<SpriteRenderer>().sprite = square;
            onepick = false;
            this.transform.position = new Vector3(0, 0, 0);
            GetComponent<Movement>().enabled = true;
            GetComponent<Shooting>().enabled = true;
        }
        if (Input.GetButton(input2))
        {
            gameObject.tag = "CirclePlayer";
            gameObject.layer = 15;
            GetComponent<SpriteRenderer>().sprite = circle;

            onepick = false;
            this.transform.position = new Vector3(0, 0, 0);
            GetComponent<Movement>().enabled = true;
            GetComponent<Shooting>().enabled = true;
        }
        if (Input.GetButton(input3))
        {
            gameObject.tag = "TrianglePlayer";
            gameObject.layer = 14;
            GetComponent<SpriteRenderer>().sprite = triangle;

            onepick = false;
            this.transform.position = new Vector3(0, 0, 0);
            GetComponent<Movement>().enabled = true;
            GetComponent<Shooting>().enabled = true;
        }
        //dying = true;
        //die();




        //invuln = true;
        // this.transform.position = new Vector3(0, 0, 0);
        // StartCoroutine(waitres());

        //invuln = false;

    }
}
