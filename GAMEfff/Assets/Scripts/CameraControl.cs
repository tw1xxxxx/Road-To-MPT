using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoCache
{
    [SerializeField] private Transform _Player;

    private Vector3 _offset = new Vector3(3f, 0.653f, -0.06f );
    private float _speed = 3.5f;


    public override void OnTick()
    {
        var targetPosition =_Player.TransformPoint(_offset);
        transform.position = Vector3.Lerp(transform.position, targetPosition, _speed* Time.deltaTime);
        var direction = _Player.position - transform.position;
        var rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, _speed* Time.deltaTime);
    }
}
//1.99f, 0.653f, 0.001f