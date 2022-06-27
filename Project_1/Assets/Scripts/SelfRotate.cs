using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRotate : MonoBehaviour
{
    
     [SerializeField] float speed;

     [SerializeField] GameObject orbit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.RotateAround(orbit.transform.position, Vector3.up, speed * Time.deltaTime); //// Spin the object around the itself at a certain speed.
    }

  
}
