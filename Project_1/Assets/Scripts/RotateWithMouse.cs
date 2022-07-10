using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithMouse : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f; //camera speed
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            float x = Input.GetAxis("Mouse X") * speed * Time.deltaTime; // x axis for camera rotation
            float y = Input.GetAxis("Mouse Y") * speed * Time.deltaTime; // y axis for camera rotation
            transform.Rotate(0,x,0); // rotate the camera on the x axis
            transform.Rotate(y,0,0); // rotate the camera on the y axis
        }
    }
}
