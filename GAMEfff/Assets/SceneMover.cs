using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMover : MonoCache
{
    private float _Speed;
    
    public override void OnTick()
    {
        _Speed = -11.25f;

        transform.Translate(0, 0, _Speed);
    }
}
