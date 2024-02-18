using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private string SceneToLoad;

    public GameObject pauseMenu, panelEnd;

    public bool isPaused;


    public void ChangeScene()

    {

        SceneManager.LoadScene(SceneToLoad);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        // Redémarrer la partie
        panelEnd.SetActive(false);
        GameManager.instance.StartNewGame();
        

    }

    

    void Start()
    {
        pauseMenu.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                resumeGame();
            }

            else
            {
                pauseGame();
            }
        }
    }

    public void pauseGame()

    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void resumeGame()

    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    
}
