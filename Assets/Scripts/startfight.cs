using UnityEngine;
using System.Collections;

public class startfight : MonoBehaviour
{
    public int player;
    public string input1 = "square", input2 = "circle", input3 = "triangle";
    public Sprite circle, triangle, square;
    public GameObject PlayerCircle, PlayerTriangle, PlayerSquare;
    public bool pick;


    // Use this for initialization


    void Start()
    {
        pick = true;
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
        print(Time.timeScale);
        if (pick)
        {
            Time.timeScale = 0;
            pickshape();
        }
    }
    void pickshape()
    {


        if (Input.GetButton(input1))
        {

            gameObject.tag = "SquarePlayer";
            gameObject.layer = 13;
            GetComponent<SpriteRenderer>().sprite = square;
            pick = false;
            
            Time.timeScale = 1;
            print("we made it");
        }
        if (Input.GetButton(input2))
        {
            gameObject.tag = "CirclePlayer";
            gameObject.layer = 15;
            GetComponent<SpriteRenderer>().sprite = circle;

            pick = false;
            
            Time.timeScale = 1;
        }
        if (Input.GetButton(input3))
        {
            gameObject.tag = "TrianglePlayer";
            gameObject.layer = 14;
            GetComponent<SpriteRenderer>().sprite = triangle;

            pick = false;
            
            Time.timeScale = 1;
        }
    }
}
