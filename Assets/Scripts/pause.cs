using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public static bool pauseGame = false;
    public static bool showGUI = false;
    public GameObject pauseMenu;
    public static bool GameOver = false;


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.T))
        {
            GameOver = true;
            Unpause();
        }
            

        pauseMenu.SetActive(showGUI);

        if (Input.GetKeyDown(KeyCode.Escape))
            Unpause();
        
    }


    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void Unpause()
    {
        if (!GameOver && BeginGame.ingame == true)
            pauseGame = !pauseGame;

        if (pauseGame == true)
        {
            Time.timeScale = 0;
            pauseGame = true;
            showGUI = true;

        }
        else if(BeginGame.ingame == true)
        {
            Time.timeScale = 1;
            pauseGame = false;
            showGUI = false;

        }


        if (GameOver)
        {
            Time.timeScale = 0;
            pauseGame = true;
            showGUI = true;
            pauseMenu.SetActive(showGUI);
        }

    }

    void ShowResults()
    {
        //player 1 or 2 wins;
        //show points for each player too here?
    }

    public void Quit()
    {
        Application.Quit();
    }
}

