using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ret : MonoBehaviour
{
    public GameObject c63;
    public GameObject BatmanCar;
    public GameObject bmw;
    public GameObject mos;
    public void Start()
    {   
        int wow = NewCarChoiceController.ChousenCar;
        if( wow == 0){
        c63.SetActive(true);
        }
        if( wow == 1){
        BatmanCar.SetActive(true);
        }
        if(wow == 2){
        bmw.SetActive(true);
        }
        if(wow == 3){
        mos.SetActive(true);
        }
    }
}