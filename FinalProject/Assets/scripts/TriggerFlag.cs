using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFlag : MonoBehaviour
{
    public GameObject Flag;

     void OnTriggerEnter (Collider other)
     {
         if (other.gameObject.tag == Flag.tag) 
         {
             switch(Flag.tag)
             {
                case "GreenFlag":
                    ChangeScenes.GreenFlagTriggered = true;
                    break;
                case "RedFlag":
                    ChangeScenes.RedFlagTriggered = true;
                    break;
             }

             if(ChangeScenes.GreenFlagTriggered && ChangeScenes.RedFlagTriggered){
                 ChangeScenes.ChangeScene();
             }
         }
     }
}
