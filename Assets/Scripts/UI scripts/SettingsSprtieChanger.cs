using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsSprtieChanger : MonoBehaviour
{
    //public SpriteRenderer spriteRenderer;
    public Image spriteImage;
    public Sprite soundOffSprite;
    public Sprite soundOnSprite;
    public Sprite Controls1;
    public Sprite Controls2;    
    public void soundChange()
    {
        if (spriteImage.sprite == soundOnSprite)
        {
        spriteImage.sprite = soundOffSprite;
        }
        else 
        {
        spriteImage.sprite = soundOnSprite;
        }
    }

    public void rightArrowButton()
    {
        spriteImage.sprite = Controls2;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
