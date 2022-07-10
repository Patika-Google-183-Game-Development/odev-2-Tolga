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


    IEnumerator FollowPlanet()
    {
        int planetIndex = Random.Range(0, planet.Length); // get random planet index
        // get random planet position and set it as target position for meteor. 
        Vector3 targetPos = planet[planetIndex].transform.position;
        // get targePos name
        Debug.Log(planet[planetIndex].name);


        // while true, follow the planet
        while (true)
        {
            // get the distance between meteor and planet
            float distance = Vector3.Distance(transform.position, targetPos);

            // move the meteor towards the planet            
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

            // if distance is less than 1, stop following the planet.
            if (distance < 1)
            {
                // destoy meteor.
                Destroy(gameObject);
            }

            yield return new WaitForFixedUpdate(); // wait for next frame.
        }

    }
}
