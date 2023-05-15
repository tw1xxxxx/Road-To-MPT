using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score_Pref : MonoBehaviour
{
    int a;
    public static int NewRecordRaceInfo;
    public Text Main_Score;
    public static int New_Score;
    private void Start()
    {   
        int all_score = PlayerPrefs.GetInt("All_Score");
        Main_Score.text = (menu.alfa).ToString();
        if(PlayerCollision.CrashCheck == 1){
            int New_Score = Pointsss.max_score;
            PlayerPrefs.SetInt("OLD_Score", New_Score);
            if(New_Score >= all_score){
                NewRecordRaceInfo = New_Score;
                PlayerPrefs.SetInt("All_Score", NewRecordRaceInfo);
            }
            Main_Score.text = (all_score).ToString();
        }
    }
}

