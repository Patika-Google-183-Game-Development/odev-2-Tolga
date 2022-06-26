using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!rb)
            return;
        
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddForce(new Vector3(0, 0, -10f), ForceMode.Acceleration);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.AddForce(new Vector3(0, 0, 10f), ForceMode.Acceleration);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(new Vector3(10f, 0, 0), ForceMode.Acceleration);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(new Vector3(-10f, 0, 0), ForceMode.Acceleration);
            }
      
          

    }
}
