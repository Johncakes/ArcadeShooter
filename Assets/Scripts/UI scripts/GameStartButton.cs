using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class GameStartButton : MonoBehaviour
{
    
    public Animator animator; 

    public Button startButton;
    
    SettingsSprtieChanger settingsSprtieChanger;

    private mainsound sound;

    void Start() 
    {
        Button btn = startButton.GetComponent<Button>(); 
        settingsSprtieChanger = GameObject.FindGameObjectWithTag("MainImage").GetComponent<SettingsSprtieChanger>();
        sound = FindObjectOfType<mainsound>();
    }

    public void fadeToLvl()
    {
        sound.start();
        animator.SetTrigger("GameStart");
    }

    public void LaunchSettings()
    {
        animator.SetTrigger("LaunchSetting");
    }

    public void soundChange()
    {
        settingsSprtieChanger.soundChange();
        //animator.SetTrigger("SoundOff");
    }

    public void gamestart()
    {
        SceneManager.LoadScene(sceneName:"MainGame");
    }
    
    public void menubutton()
    {
        SceneManager.LoadScene(sceneName:"StartingScene");
    }
    public void quit()
    {
        Application.Quit();
    }
}