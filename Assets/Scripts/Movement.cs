using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float speed;
    public int player;
    private Rigidbody2D rb;
    string[] inputs = { "Horizontal", "Vertical"};

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (player == 2)
        {
            for(int i = 0;i<2;i++)
                inputs[i] = inputs[i] + "-" + player.ToString();
        }
    }

    void FixedUpdate()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = 0;
        move();
    }

    void move()
    {
        
        transform.position += (Vector3.right * Input.GetAxis(inputs[0]) + Vector3.up * Input.GetAxis(inputs[1])).normalized * speed * Time.deltaTime;
    }
}
