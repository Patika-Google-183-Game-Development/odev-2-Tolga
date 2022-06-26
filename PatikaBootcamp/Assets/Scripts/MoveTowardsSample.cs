using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsSample : MonoBehaviour
{
    [SerializeField] Transform _target;
    [SerializeField] float speedCoef;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //
        float movementSpeed = speedCoef * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, _target.position, movementSpeed);
    }
}
