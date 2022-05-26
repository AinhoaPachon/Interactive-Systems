using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScenes : MonoBehaviour
{
    public GameObject player;
    static int count = 0;

    // SceneManager.LoadScene("Game");

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider c)
    {
        //Debug.Log("ha entrado al trigger");
        ////Acciones a realizar cuando se detecta una entrada al Trigger.
        //if (player.isInIsalnd)
        //{
        //    player.trackerOutOfGround();

        //}

    }
}
