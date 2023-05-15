using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiBred : MonoBehaviour
{
    public GameObject Car;
    void OnCollisionExit(Collision collisionInfo){
        if(collisionInfo.collider.tag == "Obstacle"){
            Destroy(Car);
        
    }
}
}
