using UnityEngine;
using System.Collections;

public class triangleshot : MonoBehaviour
{
    public GameObject bulletStart, bulletEnd, bullet;
    Vector2 shootDirection, endvector;
    public float speed;
    public int counterMax;
    private int counter;
    //public static Object prefab = Resources.Load("Prefabs/Disk2");
    // Use this for initialization
    void Start()
    {
        bullet = Resources.Load("trianglebullet") as GameObject;
        counter = counterMax;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Jump"))
        {
            if (counter == counterMax)
            {
                GameObject projectile = Instantiate(bullet) as GameObject;
                projectile.transform.position = bulletStart.transform.position;
                Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
                endvector = bulletEnd.transform.position - transform.position;
                endvector.Normalize();


                rb.velocity = endvector * speed;
                counter = 0;
            }
            counter++;
        }


        if (!Input.GetButton("Jump"))
        {
            if(counter != counterMax)
            {
                counter++;
            }
        }
    }

}

