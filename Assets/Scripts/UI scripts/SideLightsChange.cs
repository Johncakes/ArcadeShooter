using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SideLightsChange : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{
    public Image mainImage;
    public Animator animator;
    public int ButtonID;
    private ButtonSound sound;

    void Start()
    {
        sound = FindObjectOfType<ButtonSound>();
    }

     public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("HIGHLIGHTED");
        if (ButtonID == 1)
        {
            animator.SetBool("Light 1", true);
            sound.Play();
        }
        else if (ButtonID == 2)
        {
            animator.SetBool("Light 2", true);
            sound.Play();
        }
        else
        {
            animator.SetBool("Light 3", true);
            sound.Play();
        }
    }

    public void OnPointerExit(PointerEventData eventData1)
    {
        animator.SetBool("Light 1", false);
        animator.SetBool("Light 2", false);
        animator.SetBool("Light 3", false);
    }
}
