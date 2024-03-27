using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovementBehaviour : MonoBehaviour
{
    [Tooltip("The object the enemy will be seeking towards.")]
    [SerializeField]
    private GameObject _target;
    [Tooltip("The force that will be applied to object to move it.")]
    [SerializeField]
    private float _moveForce;
    [Tooltip("The maximum magnitude this enemy's velocity can have.")]
    [SerializeField]
    private float _maxVelocity;

    private NavMeshAgent _navigation;

    public GameObject Target
    {
        get
        {
            return _target;
        }
        set 
        {
            _target = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //store the navigation component.
        _navigation = GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        //If a target hasn't been set return
        if (!_target)
            return;

        _navigation.destination = _target.transform.position;


        //If the velocity goes over the max magnitude, clamp it
        if (_navigation.velocity.magnitude > _maxVelocity)
            _navigation.velocity = _navigation.velocity.normalized * _maxVelocity;
    }
}
