using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreaterSoundVolume : MonoBehaviour
{

public string createdTag;


private void Awake(){
    GameObject obj = GameObject.FindWithTag(this.createdTag);
    if(obj != null)
    {
        Destroy(this.gameObject);
    }
    else
    {
        this.gameObject.tag = this.createdTag;
        DontDestroyOnLoad(this.gameObject);

    }
}
}