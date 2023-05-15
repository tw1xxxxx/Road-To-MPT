using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner0 : MonoBehaviour
{
    [SerializeField] private GameObject RS;
    [SerializeField] private GameObject Car;
    [SerializeField] private GameObject SUBA;
    [SerializeField] private GameObject GRUZ;
    [SerializeField] private GameObject GTR;
    [SerializeField] private GameObject AMERICAN;

    
    private void Start()
    {
        InvokeRepeating("SpawnItem", 0, Random.Range(3f, 4f));
    }
    private void SpawnItem()
    {
        var a=Random.Range(1, 6);
        if(a==1)
        {
            Instantiate(RS);
            RS.transform.position = new Vector3( Random.Range(0.7f, 0.89f), 1.3f, 367f);
        }
        if(a==2)
        {
            Instantiate(SUBA);
            SUBA.transform.position = new Vector3( Random.Range(0.7f, 0.89f), 1.3f, 367f);
        }
        if(a==3)
        {
            Instantiate(GRUZ);
            GRUZ.transform.position = new Vector3( Random.Range(0.7f, 0.89f), 1.3f, 367f);
        }
        if(a==4)
        {
            Instantiate(Car);
            Car.transform.position = new Vector3( Random.Range(0.7f, 0.89f), 1.3f, 367f);
        }
        if(a==5)
        {
            Instantiate(GTR);
            GTR.transform.position = new Vector3( Random.Range(0.7f, 0.89f), 1.046f, 367f);
        }
        if(a==6)
        {
            Instantiate(AMERICAN);
            AMERICAN.transform.position = new Vector3( Random.Range(0.7f, 0.89f), 1.3f, 367f);
        }
       
          
    }
}




 
    

   
