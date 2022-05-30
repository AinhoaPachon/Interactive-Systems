using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTracker : MonoBehaviour
{
    public GameObject tracker; //the tracker 
    public float moveRate;
    public bool isInIsalnd = true;

    void Start()
    {
        //transform.position = new Vector3(0.3f, 0.0f, 0.7f);
    }
    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveRate);

        if (isInIsalnd)
        {
            transform.position = tracker.transform.position;
        }
    }

    public void trackerOutOfGround()
    {
        isInIsalnd = false;
        Debug.Log(isInIsalnd);
    }
}
