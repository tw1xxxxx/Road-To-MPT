using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialAmericanScript : MonoCache
{
    private float _carSpeed;
    public override void OnTick()
    {
        _carSpeed -= +0.003f;
        transform.Translate(0f,0f,_carSpeed);
    }
}
