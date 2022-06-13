using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public static bool GreenFlagTriggered;
    public static bool RedFlagTriggered;

    public static int currentLevel = 0;
    public static string[] levels = new string[] { "Level 1", "Level 2", "Level 3", "Level 4", "End" };


    // Start is called before the first frame update
    void Start()
    {
        GreenFlagTriggered = false;
        RedFlagTriggered = false;
       
    }


    public static void ChangeScene()
    {
        SceneManager.LoadScene(levels[currentLevel]);
        //restart booleans
        GreenFlagTriggered = false;
        FollowTrackerPhysics.GreenPlayerCanMove = true;

        RedFlagTriggered = false;
        FollowTrackerPhysics.RedPlayerCanMove = true;
    }

}
