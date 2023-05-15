using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner1 : MonoBehaviour
{
    //public int min;
    [SerializeField] private GameObject RS;
    [SerializeField] private GameObject Car;
    [SerializeField] private GameObject SUBA;
    [SerializeField] private GameObject GRUZ;
    [SerializeField] private GameObject GTR;
    [SerializeField] private GameObject AMERICAN;
    
    
    
    private void Start()
    {
        InvokeRepeating("SpawnItem", 0, Random.Range(2.88f, 4f));          
    }
    private void SpawnItem()
    {
        var a=Random.Range(1, 7);
        if(a==1)
        {
            Instantiate(RS);
            RS.transform.position = new Vector3( Random.Range(2.71f, 2.91f), 1.3f, 353.5f);
        }
        if(a==2)
        {
            Instantiate(SUBA);
            SUBA.transform.position = new Vector3( Random.Range(2.71f, 2.91f), 1.3f, 353.5f);
        }
        if(a==3)
        {
            Instantiate(GRUZ);
           GRUZ.transform.position = new Vector3( Random.Range(2.71f, 2.91f), 1.3f, 353.5f);
        }
        if(a==4)
        {
            Instantiate(Car);
            Car.transform.position = new Vector3( Random.Range(2.71f, 2.91f), 1.3f, 353.5f);
        }  
        if(a==5)
        {
            Instantiate(GTR);
            GTR.transform.position = new Vector3( Random.Range(2.71f, 2.91f), 1.04f, 353.5f);
        }  
        if(a==6)
        {
            Instantiate(AMERICAN);
            AMERICAN.transform.position = new Vector3( Random.Range(2.71f, 2.91f), 1.64f, 353.5f);
        }  
    }
}