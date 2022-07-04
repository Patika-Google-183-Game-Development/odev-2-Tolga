using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InfoPanel : MonoBehaviour
{

    public GameObject panel;
    private int clicked = 0;

    public TMP_Text planet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) // select clicked object
            {
                // if object name equals planet show UI
                if (hit.transform.gameObject.name == "Earth") 
                {
                    clicked++;
                    panel.SetActive(true); // open UI
                    planet.text = "Earth"; // set text
                    Debug.Log("EARTH CLİCKED");
                    if (clicked > 1 && panel != null) // close UI after second click
                    {
                        clicked = 0;
                        panel.SetActive(false);
                    }
                }
                if (hit.transform.gameObject.name == "Mars")
                {
                    clicked++;
                    panel.SetActive(true);
                    planet.text = "Mars";
                    Debug.Log("Mars CLİCKED");
                    if (clicked > 1 && panel != null)
                    {
                        clicked = 0;
                        panel.SetActive(false);
                    }
                }
                if (hit.transform.gameObject.name == "Saturn")
                {
                    clicked++;
                    panel.SetActive(true);
                    planet.text = "Saturn";
                    Debug.Log("Saturn CLİCKED");
                    if (clicked > 1 && panel != null)
                    {
                        clicked = 0;
                        panel.SetActive(false);
                    }
                }
                if (hit.transform.gameObject.name == "Sun")
                {
                    clicked++;
                    panel.SetActive(true);
                    planet.text = "Sun";
                    Debug.Log("Sun CLİCKED");
                    if (clicked > 1 && panel != null)
                    {
                        clicked = 0;
                        panel.SetActive(false);
                    }
                }

            }


        }


    }
}
