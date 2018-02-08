using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Shooting : MonoBehaviour {
    public GameObject bulletStart, bulletEnd, bullet;
    Vector2 shootDirection, endvector, barrierendvec;
    public float speed = 6;
    public int counterMax, player;
    private string[] inputs = { "Shoot", "Barrier" };
    public int counter;
    public AudioClip shootClip;
    
    //public static Object prefab = Resources.Load("Prefabs/Disk2");
    // Use this for initialization
    void Start()
    {
        //AudioSource audio = GetComponent<AudioSource>();
        if (player == 2)
        {
            for (int i = 0; i < 2; i++)
                inputs[i] = inputs[i] + "-" + player.ToString();
        }

        //bullet = Resources.Load("trianglebullet") as GameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "SquarePlayer"){
            bullet = Resources.Load("squarebullet") as GameObject;
        }else if (gameObject.tag == "TrianglePlayer"){
            bullet = Resources.Load("trianglebullet") as GameObject;
        }else if (gameObject.tag == "CirclePlayer"){
            bullet = Resources.Load("circlebullet") as GameObject;
        }

        if (Input.GetButton(inputs[0]))
        {
            if (counter == counterMax)
            {
                GameObject projectile = Instantiate(bullet) as GameObject;
                projectile.transform.position = bulletStart.transform.position;
                projectile.transform.rotation = Quaternion.AngleAxis(transform.rotation.eulerAngles.z, Vector3.forward);
                Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
                endvector = bulletEnd.transform.position - transform.position;
                endvector.Normalize();
                

                rb.velocity = endvector * speed;
                counter = 0;
                

                GetComponent<AudioSource>().Play();
            }
            counter++;
        }

        else if (!Input.GetButton(inputs[0]))
        {
            if (counter != counterMax)
            {
                counter++;
            }
        }
    }
}
