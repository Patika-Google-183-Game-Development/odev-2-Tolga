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
        StartCoroutine(Spinning());
    }

    IEnumerator Spinning()
    {
        while (true)
        {
            transform.RotateAround(orbit.transform.position, Vector3.up, speed * Time.deltaTime);
            yield return new WaitForFixedUpdate();
        }
    }
}
