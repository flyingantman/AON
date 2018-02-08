using UnityEngine;
using System.Collections;

public class floorspin : MonoBehaviour {
    public int speed;
	// Use this for initialization
	void Start () {
        speed = 2;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward * Time.deltaTime * speed);
    }
}
