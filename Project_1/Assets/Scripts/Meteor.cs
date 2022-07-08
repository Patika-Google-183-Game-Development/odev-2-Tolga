using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField] private GameObject[] planet;
    [SerializeField] private float speed = 2.0f;

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FollowPlanet());
    }


    IEnumerator FollowPlanet() {
        int planetIndex = Random.Range(0,planet.Length);
        transform.position = Vector3.MoveTowards(transform.position,planet[planetIndex].transform.position, speed * Time.deltaTime);
       
        yield return new WaitForFixedUpdate();
         StartCoroutine(FollowPlanet());
         
    }
}
