using UnityEngine;
using System.Collections;

public class spin : MonoBehaviour {


    private float spinspeed;
	// Use this for initialization
	void Start () {
        spinspeed = Random.Range(-30, 30);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, 1 * spinspeed * Time.deltaTime);

        if (((int) Timer.timeleft) % 60 == 0)
            spinspeed = Randomizespeed();
    }

    float Randomizespeed()
    {
        float speed = Random.Range(-30, 30);
        return speed;
    }


    
}
