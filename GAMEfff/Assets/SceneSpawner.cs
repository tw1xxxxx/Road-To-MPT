using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSpawner : MonoBehaviour
{
    [SerializeField] private GameObject CarST;
    //[SerializeField] private GameObject GruzST;
   // [SerializeField] private GameObject SubaST;
    //[SerializeField] private GameObject RSST;
    
    private void Start()
    {
        InvokeRepeating("SpawnItem", 0, Random.Range(15f, 27f));
    }
    private void SpawnItem(){
//    {
//        var a=Random.Range(1, 4);
//        if(a==1)
//        {
            Instantiate(CarST);
            CarST.transform.position = new Vector3( 540f, 1080f, 1.9f);
//        }
//        if(a==2)
//        {
//            Instantiate(SUBA);
//            SUBA.transform.position = new Vector3( Random.Range(0.7f, 0.89f), 1.3f, 367f);
//        }
//        if(a==3)
//        {
//            Instantiate(GRUZ);
 //           GRUZ.transform.position = new Vector3( Random.Range(0.7f, 0.89f), 1.3f, 367f);
//        }
//        if(a==4)
///        {
//            Instantiate(Car);
//            Car.transform.position = new Vector3( Random.Range(0.7f, 0.89f), 1.3f, 367f);
//        }  
//    }
//}
}
}
