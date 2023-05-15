using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject GameObject;
    
    void OnCollisionExit(Collision collisionInfo){
        if(collisionInfo.collider.tag == "Cube"){
            Destroy(GameObject);
        }
    }
}
