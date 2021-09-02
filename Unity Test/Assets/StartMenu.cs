using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject settingsMenu;
    
    public void StartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Options ()
    {
        startMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
