using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadScript : MonoCache
{
    private float _offset;
    public override void OnTick()
    {
         _offset -=0.09f;
         GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, _offset);  
    }
}
