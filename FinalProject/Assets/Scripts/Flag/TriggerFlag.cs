using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFlag : MonoBehaviour
{
    public GameObject Flag;
    public AudioSource LevelFishedAudio;
    public GameObject Confetti;

     IEnumerator OnTriggerEnter (Collider other)
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
                Confetti.GetComponent<ParticleSystem>().Play();
                LevelFishedAudio.Play();
                yield return new WaitForSeconds(5);
                ChangeScenes.currentLevel++;
                ChangeScenes.ChangeScene();
             }
         }
     }
}
