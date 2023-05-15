using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public static int alfa;
    public static int z;
    public Text score;
    public GameObject NewGame;
    public GameObject Menu;
    public GameObject SettingsMenu;
    public GameObject CarsMenu;
    public GameObject ButtonBack;
    public GameObject Starting;
   
    public void StartScreen(){
        SceneManager.LoadScene(3);
        SceneManager.LoadScene(1);
        alfa = (PlayerPrefs.GetInt("All_Score"));
    }
    public void Back(){
        SceneManager.LoadScene(1);
        z=0;
    }
    public void play()
    {
        SceneManager.LoadScene(2);
    }
    public void Settings(){
        SceneManager.LoadScene(3);
    }
    public void Exit(){
        Application.Quit();
    }
    public void Cars(){
        SceneManager.LoadScene(5);
        z = 1;
    }
}