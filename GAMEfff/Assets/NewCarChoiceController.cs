using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//исходя из опыта лучше писать комы
public class NewCarChoiceController : MonoBehaviour
{
    public Text CarName;//Название
    public static int ChousenCar;//инфа о позиции для передачи на другую сцену
    public static int car_pos;//просто для выгрузки инфы
    public GameObject ButtonCar_0;//Визуал
    public GameObject ButtonCar_1;//Визуал
    public GameObject ButtonCar_2;//Визуал
    public GameObject Car_0;//Машина
    public GameObject Car_1;//Машина
    public GameObject Car_2;//Машина

   
    public void Start()
    {
        car_pos = PlayerPrefs.GetInt("Car_menu_position");//это база
        if(car_pos == 0){
            CarName.text = ("Mersedes C63").ToString();
            Car_0.SetActive(true);
            ButtonCar_0.SetActive(true);
        }
        if(car_pos == 1){
            CarName.text = ("CyberCar").ToString();
            Car_1.SetActive(true);
            ButtonCar_1.SetActive(true);
        }
        if(car_pos == 2){
           CarName.text = ("BMW E30").ToString();
           ButtonCar_2.SetActive(true);
           Car_2.SetActive(true);
        }
        //меня не волнует что это костыли
    }
    public void Button_0(){
        if(car_pos != 0){
        CarName.text = ("Mersedes C63").ToString();
        Car_0.SetActive(true);
        Car_1.SetActive(false);
        Car_2.SetActive(false);

        ButtonCar_0.SetActive(true);
        ButtonCar_1.SetActive(false);
        ButtonCar_2.SetActive(false);
        }
        car_pos=0;
        PlayerPrefs.SetInt("Car_menu_position", 0);
        ChousenCar=0;
    }
    public void Button_1(){
        if(car_pos != 1){
        CarName.text = ("CyberCar").ToString();
        Car_1.SetActive(true);
        Car_2.SetActive(false);
        Car_0.SetActive(false);
        ButtonCar_0.SetActive(false);
        ButtonCar_2.SetActive(false);
        ButtonCar_1.SetActive(true);

        }
        car_pos=1;
        PlayerPrefs.SetInt("Car_menu_position", 1);
        ChousenCar=1;
    }
    public void Button_2(){
        if(car_pos != 2){
        CarName.text = ("BMW E30").ToString();
        Car_0.SetActive(false);
        Car_2.SetActive(true);
        Car_1.SetActive(false);

        ButtonCar_0.SetActive(false);
        ButtonCar_1.SetActive(false);
        ButtonCar_2.SetActive(true);
        
        }
        car_pos = 2;
        PlayerPrefs.SetInt("Car_menu_position", 2);
        ChousenCar = 2;
    }
}
