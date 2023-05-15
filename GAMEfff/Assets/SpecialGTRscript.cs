using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialGTRscript : MonoCache
{
    private float _carSpeed;
    public override void OnTick()
    {
        _carSpeed -= -0.002f;
        transform.Translate(0f, _carSpeed, 0);
    }
}