using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addscores : MonoBehaviour
{
    public int playerscore;
    public Text scoreText;
    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerscore = playerscore + 1;
        scoreText.text = playerscore.ToString();
    }

}
