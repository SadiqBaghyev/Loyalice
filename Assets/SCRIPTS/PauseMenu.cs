using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused;

    public GameObject pauseMenu;
    //public GameObject optionsMenu;
    public GameObject panelPauseMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        panelPauseMenu.SetActive(false);
        //optionsMenu.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        panelPauseMenu.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void pauseSettings()
    {
        pauseMenu.SetActive(false);
        panelPauseMenu.SetActive(true);
        //optionsMenu.SetActive(true);
    }

    public void X()
    {
        pauseMenu.SetActive(true);
        panelPauseMenu.SetActive(true);
        //optionsMenu.SetActive(false);
    }
    public void quitMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void mainX()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void SetQuality(int qual)
    {
        QualitySettings.SetQualityLevel(qual);    
    }
}