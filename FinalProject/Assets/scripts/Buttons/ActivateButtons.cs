using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateButtons : MonoBehaviour
{
    public GameObject bridge;
    public GameObject button;

  

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(button.tag))
        {
            bridge.SetActive(true);
        }
    }
}
