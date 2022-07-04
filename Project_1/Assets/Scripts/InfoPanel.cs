using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoPanel : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

                if (hit.transform.gameObject.name == "Earth")
                {
                    Debug.Log("EARTH CLİCKED");
                }
                 if (hit.transform.gameObject.name == "Mars")
                {
                    Debug.Log("Mars CLİCKED");
                }
                 if (hit.transform.gameObject.name == "Saturn")
                {
                    Debug.Log("Saturn CLİCKED");
                }
                if (hit.transform.gameObject.name == "Sun")
                {
                    Debug.Log("Sun CLİCKED");
                }

            }


        }


    }
}
