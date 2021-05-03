using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]private levelChanger lvlChanger;
    public GameObject playerGameObject;
    public GameObject powerUp;
    public Text lifeText;
    public Text ScoreText;
    public GameObject EnemiesSponer;

    
    Attack attack;
    int Score;
    int repeatNum;
    BGMgame sound;


    bool playerIsAlive = true;
    public bool developerMode;
    bool allowFire = true;
    bool BossSpon;
    private void Start() 
    {
        attack = GameObject.FindGameObjectWithTag("Player").GetComponent<Attack>();
        sound = FindObjectOfType<BGMgame>();
        sound.field();
    }
    public void PlayerDeath()
    {
        playerIsAlive = false;
        Destroy(GameObject.FindGameObjectWithTag("Player"), 2.0f);
        lvlChanger.gameEnd();
        PlayerPrefs.SetInt("Score",Score);

        if(PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", Score);
        }

    }

    // Update is called once per frame
   public bool playerState()
   {
       return playerIsAlive;
   }
   public bool developerState()
   {
       return developerMode;
   }
   public void fire()
   {
       allowFire = !allowFire;
   }
   public bool fireState()
   {
       return allowFire;
   }
   public void lifeDecrease(int a)
   {
       dropPowerUps();
       lifeText.text = a.ToString(); 
    }

    void dropPowerUps()
    {
        //Debug.Log("FUCK");
        repeatNum = attack.return_Player_Level();

        //Debug.Log("REPEAT NUM : " +repeatNum);
        for (int j = 1; j < repeatNum; j++)
        {
            //Debug.Log("AHHHHHHHHHHHHHHHH");
            Instantiate(powerUp,playerGameObject.transform.position, playerGameObject.transform.rotation); 
        }
    }
    public void scoreUp(int scorepoint)
    {
        Score += scorepoint;
        ScoreText.text = Score.ToString("00000");
        
    }


    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.R) && developerMode == true)
        {
            SceneManager.LoadScene("MainGame");
        }
        if(Input.GetKeyDown(KeyCode.K))
        {
            EnemiesSponer.SetActive(false);
        }
    }
}
