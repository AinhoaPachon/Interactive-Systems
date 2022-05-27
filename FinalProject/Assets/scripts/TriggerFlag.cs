using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFlag : MonoBehaviour
{
    public GameObject Flag;
    public GameObject Tracker; 

     void OnTriggerEnter (Collider other)
     {
         if (other.gameObject.tag == Flag.tag) 
         {
             switch(Flag.tag)
             {
                case "GreenFlag":
                    FollowTrackerPhysics.GreenPlayerCanMove = false;
                    ChangeScenes.GreenFlagTriggered = true;
                    break;
                case "RedFlag":
                    FollowTrackerPhysics.RedPlayerCanMove = false;
                    ChangeScenes.RedFlagTriggered = true;
                    break;
             }

             if(ChangeScenes.GreenFlagTriggered && ChangeScenes.RedFlagTriggered){
                 ChangeScenes.ChangeScene();
             }
         }
     }
}
