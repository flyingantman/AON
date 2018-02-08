using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour {

    public bool showGUIb, showGUIc;
    public static bool ingame;
    public GameObject blayout;
    public GameObject credlayout;
    public GameObject pregame;
    public GameObject EventSystem;
    public Sprite Knob;
    private int started = 0;
    private int untilpre = 0;
    private int[] bothgood = { 0, 0 };

    public GameObject[] Player;

    // Use this for initialization
    void Start () {
        showGUIb = true;
        showGUIc = false;
        blayout.SetActive(showGUIb);
        credlayout.SetActive(showGUIc);
        pregame.SetActive(!showGUIb);
        ingame = false;
        started = 0;
        untilpre = 0;
        bothgood[0] = 0;
        bothgood[1] = 0;
    }

    public void StartGame()
    {
        PreGame();
        Timer.timeleft = 300;
        untilpre = 1;
        Debug.Log("why isn't this working at all");
        showGUIb = false;
        blayout.SetActive(showGUIb);
        pregame.SetActive(!showGUIb);
        Time.timeScale = 1;
        

    }

    void UntilPreGame()
    {
        foreach (GameObject Gamer in Player)
        {
            print("asdf");
            int i = 0;
            if (Gamer.GetComponent<SpriteRenderer>().sprite == Knob)
                bothgood[i++] = 0;

        }

        if (bothgood[0] == 1 && bothgood[1] == 1)
            started = 1;
    }

    public void PreGame()
    {
        //when both are pressed and ready to roll
        EventSystem.GetComponent<pause>().enabled = true;
        ingame = true;
        Timer.timeleft = 300;

        
    }

    void Update()
    {
        if (untilpre == 1)
            UntilPreGame();

        if (ingame != true)
        {
            if (started == 1 || Timer.timeleft < 0)
                PreGame();
        }
    }

    public void Back()
    {
        showGUIc = false;
        credlayout.SetActive(showGUIc);
    }

    public void Credits()
    {
        showGUIc = !showGUIc;
        credlayout.SetActive(showGUIc);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
