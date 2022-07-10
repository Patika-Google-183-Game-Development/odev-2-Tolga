using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRotate : MonoBehaviour
{

    [SerializeField] float speed; // speed of rotation
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spinning()); // start spinning
        
    }

    IEnumerator Spinning()
    {
        while (true) 
        {
            
            transform.Rotate(Vector3.up, speed * Time.deltaTime); // Rotates around itself
            yield return new WaitForFixedUpdate(); // wait for next frame.
        }
    }
}
