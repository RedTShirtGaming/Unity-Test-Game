using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GameManager : MonoBehaviour
{
    public PlayerSaver playerSaver;

    public AudioMixer mixer;
    public bool enableAudio = true;
    
    void Start ()
    {
        Setup();
    }

    public void Setup ()
    {        
        Cursor.lockState = CursorLockMode.Locked;

        playerSaver.LoadPlayer();
        Debug.Log("Loaded last player save point");

        if (enableAudio)
        {
            mixer.SetFloat("MasterVolume", -40);
        }
        else if (!enableAudio)
        {
            mixer.SetFloat("MasterVolume", -80);
        }
    }
}