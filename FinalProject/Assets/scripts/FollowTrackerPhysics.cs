using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTrackerPhysics : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tracker; //the tracker 
    public float moveRate;
    public float speed;


    private Rigidbody rb;


    void Start()
    {
        // Assign the Rigidbody component to our private rb variable
        rb = GetComponent<Rigidbody>();

        //transform.position = new Vector3(0.3f, 0.0f, 0.7f);
    }

    void FixedUpdate()
    {
        // Create a Vector3 variable, and assign X and Z to feature the horizontal and vertical float variables above
       
        Vector3 pos = Vector3.MoveTowards(transform.position, tracker.transform.position, moveRate);
        Vector3 movement = new Vector3(pos.x - transform.position.x , 0.0f, pos.z - transform.position.z);

        rb.AddForce(movement*speed);
    }

    
}
