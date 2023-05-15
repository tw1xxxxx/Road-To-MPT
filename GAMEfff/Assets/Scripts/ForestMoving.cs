using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestMoving : MonoCache
{
    public float _treeSpeed;

    public override void OnTick()
    {
        transform.Translate(0f, 0f, _treeSpeed);
    }
}
