using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFlagBlue : MonoBehaviour
{
    public GameObject Flag;
    public AudioSource LevelFishedAudio;
    public GameObject Confetti;

     IEnumerator OnTriggerEnter (Collider other)
     {
         if (other.gameObject.tag == Flag.tag) 
         {
            Debug.Log("trigger entered");
            Confetti.GetComponent<ParticleSystem>().Play();
            LevelFishedAudio.Play();
            yield return new WaitForSeconds(5);
            ChangeScenes.currentLevel++;
            ChangeScenes.ChangeScene();
         }
     }
}
