using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieChaser : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Bonk!");
        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
            Score counter = FindObjectOfType<Score>();
            counter.upOne();
            ChaserSpawner sp = FindObjectOfType<ChaserSpawner>();
            sp.alive = false;
        }
    }
}
