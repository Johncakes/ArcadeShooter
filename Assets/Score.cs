using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Text highScore;
    public Text score;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
        score.text = PlayerPrefs.GetInt("Score",0).ToString();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
