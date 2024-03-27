using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraMoveBehavior : MonoBehaviour
{
    [SerializeField]
    private Transform _target;

    [SerializeField]
    private float _smoothTime = 0.5f;

    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        _offset = _target.position - transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 velocity = Vector3.zero;
        transform.position = Vector3.SmoothDamp(transform.position, (_target.position - _offset), ref velocity, _smoothTime);

    }
}
