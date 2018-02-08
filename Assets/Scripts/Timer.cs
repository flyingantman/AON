using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public static float timeleft;
    public static Text timeText;

	// Use this for initialization
	void Start () {
        timeleft = 300;
        timeText = GameObject.FindWithTag("timer").GetComponent<Text>();
        timeText.text = "";
    }
	
	// Update is called once per frame
	void Update () {
        int timerfirst = (int) timeleft/60;
        int timersecond = ((int)timeleft % 60);
        int timerthird = timersecond % 10;
        timeText.text = timerfirst.ToString() + ":" + (timersecond/10).ToString() + timerthird.ToString();

        timeleft -= Time.deltaTime;
        if(timeleft < 0)
        {
            pause.GameOver = true;
        }
	}
}
