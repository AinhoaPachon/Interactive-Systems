using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject fence;
    public GameObject button;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag(button.tag))
        {
            fence.SetActive(false);
            audio.Play();
            switch(button.tag)
             {
                case "GreenButton":
                    FollowTrackerPhysics.GreenFenceActive = false;
                    break;
                case "RedButton":
                    FollowTrackerPhysics.RedFenceActive = false;
                    break;
             }

        }
    }
}
