using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;

    public GameObject pauseMenuUI;
    public GameObject settingsMenuUI;

    void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
                Cursor.lockState = CursorLockMode.Locked;
            } else
            {
                Pause();
            }
            
        }
    }

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Quit ()
    {
        Application.Quit();
    }

    public void Save ()
    {
        Resume();
        Debug.Log("Game saved");
    }

    public void Load ()
    {
        Resume();
        Debug.Log("Game loaded");
    }

    public void SettingsOpen ()
    {
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(true);
    }
}
