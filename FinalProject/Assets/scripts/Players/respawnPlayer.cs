using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnPlayer : MonoBehaviour
{
    private int limit = -10;
    public Vector3 initPos;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < limit)
        {
            transform.position = initPos;
        }
    }
}
