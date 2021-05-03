using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMain : MonoBehaviour
{
    Transform MoveLocation;
    int pattern, prevPattern;
    bool isOnPosition = false;
    bool patternStartAvailable = false;

    LaserPattern laserPattern;
    TrackerPattern trackerPattern;
    BarragePattern barragePattern;

    private void Start()
    {
        MoveLocation = GameObject.Find("BossMoveLocation").GetComponent<Transform>();

        laserPattern = GetComponent<LaserPattern>();
        trackerPattern = GetComponent<TrackerPattern>();
        barragePattern = GetComponent<BarragePattern>();
    }

    public void SetPatterAvailable()
    {
        patternStartAvailable = !patternStartAvailable;
    }

    void Update()
    {
        if(isOnPosition == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, MoveLocation.position, 0.025f);
         
            if(transform.position == MoveLocation.position)
            {
                isOnPosition = true;
                patternStartAvailable = true;
            }
        }
        
        if(patternStartAvailable == true)
        {
            patternChooser();

            switch(pattern)
            {
                case 1:
                    BarragePattern();
                    break;
                case 2:
                    LaserPattern();
                    break;
                case 3:
                    TrackerPattern();
                    break;
                default:
                    break;
            }
        }
    }

    void patternChooser()
    {
        pattern = Random.Range(2, 4);
        patternStartAvailable = false;
        //Debug.Log("Pattern = " + pattern);
        //Debug.Log("PrevPattern = " + prevPattern);
    
        if(pattern == prevPattern)
        {
            //Debug.Log("=======ReRoll!========");
            patternChooser();
        }
        prevPattern = pattern;
        patternStartAvailable = false; //Disables multi pattern.
    }
    void BarragePattern()
    {
        barragePattern.PatternCalled();
    }
    void LaserPattern()
    {
        laserPattern.PatternCalled();
    }

    void TrackerPattern()
    {
        trackerPattern.PatternCalled();
    }
    
}
