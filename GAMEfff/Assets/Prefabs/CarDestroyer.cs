using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDestroyer : MonoCache
{
    public GameObject gameobject;
    void Start() => Destroy(gameobject, 20f);
    
}

