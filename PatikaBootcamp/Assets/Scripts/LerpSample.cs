using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpSample : MonoBehaviour
{
    Vector3 startingPos;
    [SerializeField] Transform _target;
    [SerializeField] float speedCoef;
    float startTime = 0f;
    float journeyLength = 0f;
    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
        journeyLength = Vector3.Distance(startingPos, _target.position);
    }
    
    // Update is called once per frame
    void Update()
    {
        //float distanceCovered = (Time.time - startTime) * speedCoef;

        //float JourneyFraction = distanceCovered / journeyLength;
        
        //transform.position = Vector3.Lerp(startingPos,_target.position, JourneyFraction);

        transform.RotateAround(_target.position, Vector3.up, speedCoef * Time.deltaTime);
        
    }
}
