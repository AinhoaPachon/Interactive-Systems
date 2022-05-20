using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteAlways]
public class Limits : MonoBehaviour
{
    public FollowTracker player;  

    private void OnTriggerEnter(Collider c)
    {
        Debug.Log("ha entrado al trigger");
        //Acciones a realizar cuando se detecta una entrada al Trigger.
        if (player.isInIsalnd)
        {
            player.trackerOutOfGround();
            
        }

    }
    
}
