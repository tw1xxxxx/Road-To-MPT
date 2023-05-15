using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RaceInfo : MonoBehaviour
{
    public Text NewScoreInfo;
    public Text NoNewScoreInfo;
    void Start()
    {
        int a = Pointsss.max_score;
        if(a > PlayerPrefs.GetInt("All_Score"))
        {
            NewScoreInfo.text = ("NEW BEST SCORE: " + Pointsss.max_score).ToString();
        }
        else
        {
            NoNewScoreInfo.text =  ("YOUR SCORE:   " + Pointsss.max_score).ToString();
        }
    }
}
