using UnityEngine;
using System.Collections;


[RequireComponent(typeof(AudioSource))]
public class switchsound : MonoBehaviour {
    public AudioClip switching;
    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update() {

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player" || coll.gameObject.tag == "TrianglePlayer" || coll.gameObject.tag == "CirclePlayer" || coll.gameObject.tag == "SquarePlayer")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

        }
     



        }
    }

