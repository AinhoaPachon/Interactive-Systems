using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAudio : MonoBehaviour
{
    public AudioSource Audio;
    private void OnTriggerEnter(Collider other)
    {
        Audio.Play();
    }
}
