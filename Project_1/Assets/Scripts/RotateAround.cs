using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    
    [SerializeField] float speed;
    [SerializeField] Transform target;

    private float rotateValue;

    void Start()
    {
        StartCoroutine(Rotating());

    }

    IEnumerator Rotating()
    {

            transform.RotateAround(target.position, Vector3.up, speed * Time.deltaTime); //// Spin the object around the target at a certain speed.
            rotateValue += speed * Time.deltaTime; // rotateValue is the amount of degrees the object has rotated. 
            if(rotateValue > 360) { // if rotateValue more than 360 degree then reset to 0 and get log.
                rotateValue = 0;
                Debug.Log(this.gameObject.name + " Rotate Complete");
            }
            
            yield return new WaitForFixedUpdate();
            StartCoroutine(Rotating());
        
    }
    

    

}
