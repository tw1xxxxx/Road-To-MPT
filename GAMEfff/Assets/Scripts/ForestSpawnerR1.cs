using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestSpawnerR1 : MonoBehaviour
{

    [SerializeField] public GameObject WinterBiom;
    
    public void Start()
    {
        InvokeRepeating("SpawnItem", 0, 2f);       
    }
    public void SpawnItem()
    {
     
        Instantiate(WinterBiom);
        WinterBiom.transform.position = new Vector3(-4.05f, 0f, 144.6f);
    }  
}
