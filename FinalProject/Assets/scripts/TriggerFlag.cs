using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFlag : MonoBehaviour
{
    public GameObject Flag;
    public GameObject Tracker;
    public AudioSource audio;

     void OnTriggerEnter (Collider other)
     {
         if (other.gameObject.tag == Flag.tag) 
         {
             switch(Flag.tag)
             {
                case "GreenFlag":
                    if(!FollowTrackerPhysics.RedFenceActive){
                    FollowTrackerPhysics.GreenPlayerCanMove = false;
                    ChangeScenes.GreenFlagTriggered = true;
                    }
                    break;
                case "RedFlag":
                    if(!FollowTrackerPhysics.GreenFenceActive){
                    FollowTrackerPhysics.RedPlayerCanMove = false;
                    ChangeScenes.RedFlagTriggered = true;
                    }
                    break;
             }

             if(ChangeScenes.GreenFlagTriggered && ChangeScenes.RedFlagTriggered){
                 audio.Play();
                 new WaitForSeconds(6);
                 ChangeScenes.ChangeScene();
             }
         }
     }
}
