using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelChanger : MonoBehaviour
{
    public Animator animator;
    public GameObject buttonCanvas;
    
    public void gamestart()
    {
        SceneManager.LoadScene(sceneName:"MainGame");
    }
    public void removeButtons()
    {
        buttonCanvas.GetComponent<Canvas>().enabled = false;
    }
    public void gameEnd()
    {
        SceneManager.LoadScene(sceneName:"DeadScene");
    }
    public void launchSettings()
    {
        Debug.Log("Ey");
        SceneManager.LoadScene(sceneName:"Controls");
    }
    public void launchSettings2()
    {
        Debug.Log("Ey");
        SceneManager.LoadScene(sceneName:"Controls2");
    }
    public void menubutton()
    {
        Debug.Log("Ey");
        SceneManager.LoadScene(sceneName:"StartingScene");
    }

    public void setTriggerEnd()
    {
        animator.SetTrigger("GameEnd");
        Time.timeScale = 1;
    }
}
