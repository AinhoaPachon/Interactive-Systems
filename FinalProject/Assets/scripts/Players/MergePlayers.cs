using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergePlayers : MonoBehaviour
{
    public GameObject bluePlayer;
    public GameObject redPlayer;
    public GameObject greenPlayer;

    public GameObject redTracker;
    public GameObject greenTracker;

    private float maxDist = 15.0f;
    private bool isMerged = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 positionRedTracker = redTracker.transform.position;
        Vector3 positionGreenTracker = greenTracker.transform.position;

        Vector3 positionRedPlayer = redPlayer.transform.position;
        Vector3 positionGreenPlayer = greenPlayer.transform.position;

        Vector3 distTrackers = positionRedTracker - positionGreenTracker;
        float magnitudeTrackers = distTrackers.magnitude;

        Vector3 distPlayer = positionRedPlayer - positionGreenPlayer;
        float magnitudePlayers = distPlayer.magnitude;

        if (magnitudeTrackers < maxDist && magnitudePlayers < maxDist)
        {
            redPlayer.SetActive(false);
            greenPlayer.SetActive(false);

            if (!isMerged)
            {
                bluePlayer.transform.position = positionRedTracker;
                isMerged = true;
            }
            
            bluePlayer.SetActive(true);
        }
        else
        {
            redPlayer.SetActive(true);
            greenPlayer.SetActive(true);

            bluePlayer.SetActive(false);


            if (isMerged)
            {
                redPlayer.transform.position = positionRedTracker;
                greenPlayer.transform.position = positionGreenTracker;
                isMerged = false;
            }

        }
    }
    
}
