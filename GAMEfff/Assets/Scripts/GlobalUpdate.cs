using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalUpdate : MonoBehaviour
{

public void FixedUpdate()
{
    for (int i = 0; i < MonoCache.allUpdate.Count; i++) MonoCache.allUpdate[i].Tick();
}

}
