using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetScore : MonoBehaviour
{

    public void reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }
}
