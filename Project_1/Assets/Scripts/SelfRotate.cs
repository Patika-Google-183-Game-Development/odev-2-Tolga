using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRotate : MonoBehaviour
{

    [SerializeField] float speed;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spinning());
    }

    IEnumerator Spinning()
    {
        while (true)
        {
            
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
            yield return new WaitForFixedUpdate();
        }
    }
}
