using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateButtons : MonoBehaviour
{
    public GameObject fence;
    public GameObject button;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(button.tag))
        {
            fence.SetActive(false);
        }
    }
}
