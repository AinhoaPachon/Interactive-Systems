using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : MonoBehaviour
{
    public float runSpeed;
    public float gotHayDestroyDelay;
    private bool hitByHay;

    public float dropDestroyDelay;
    private Collider myCollider;
    private Rigidbody myRigidbody;

    private SheepSpawner sheepSpawner;

    public float heartOffset;
    public GameObject heartPrefab;


    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<Collider>();
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * runSpeed * Time.deltaTime);
    }

    private void HitByHay()
    {
        sheepSpawner.RemoveSheepFromList(gameObject);
        hitByHay = true;
        runSpeed = 0;
        Destroy(gameObject, gotHayDestroyDelay);

        Instantiate(heartPrefab, transform.position + new Vector3(0, heartOffset, 0), Quaternion.identity);

        TweenScale tweenScale = gameObject.AddComponent<TweenScale>();
        tweenScale.targetScale = 0;
        tweenScale.timeToReachTarget = gotHayDestroyDelay;

        SoundManager.Instance.PlaySheepHitClip();

        GameStateManager.Instance.SavedSheep();
    }

    private void OnTriggerEnter(Collider other) // 1
    {
        if (other.CompareTag("Hay") && !hitByHay) // 2
        {
            Destroy(other.gameObject); // 3
            HitByHay(); // 4
        }
        else if (other.CompareTag("DropSheep"))
        {
            Drop();
        }

    }

    private void Drop()
    {
        GameStateManager.Instance.DroppedSheep();

        sheepSpawner.RemoveSheepFromList(gameObject);
        myRigidbody.isKinematic = false; // 1
        myCollider.isTrigger = false; // 2
        Destroy(gameObject, dropDestroyDelay); // 3

        SoundManager.Instance.PlaySheepDroppedClip();

    }

    public void SetSpawner(SheepSpawner spawner)
    {
        sheepSpawner = spawner;
    }

}
