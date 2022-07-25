using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField] private GameObject[] planet;
    [SerializeField] private float speed = 15.0f;
    int index;
    void Start()
    {
        // get random planet index
        index = Random.Range(0, planet.Length);
    }

    // Update is called once per frame
    void Update()
    {
        // get the target platet position
        Vector3 targetPos = planet[index].transform.position;

        // rotate meteor directon to planet
        transform.LookAt(targetPos);
        // move meteor towards planet
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
       


    }

    private void OnCollisionEnter(Collision collision) 
       {
        
           // destroy game object if it hits the planet
            if (collision.gameObject.tag == "Planet")
            {
               // destroy clone meteor only
                if(gameObject.name == "MeteorPS(Clone)")
                {
                    Destroy(gameObject);
                }      
                
            }
    }
}
