using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public static bool GreenFlagTriggered;
    public static bool RedFlagTriggered;

    // Start is called before the first frame update
    void Start()
    {
        GreenFlagTriggered = false;
        RedFlagTriggered = false;
    }

    public static void ChangeScene(){
        SceneManager.LoadScene("Level 2");
    }

}
