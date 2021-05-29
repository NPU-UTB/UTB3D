using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserSpawner : MonoBehaviour
{
    public GameObject chaser;
    private float spawnCd;
    private float timer;
    //private float[] points = {-3.5f, 0f, 3.5f};
    public bool alive = false;
    // Start is called before the first frame update
    void Start()
    {
        spawnCd = 10f;
        timer = 8;
        Random.InitState((int)Time.time);
    }

    // Update is called once per frame
    void Update()
    {
        if (!alive)
        {
            timer += Time.deltaTime;
            if (timer >= spawnCd)
            {
                //Debug.Log("Here it comes!");
                timer = 0f;
                Vector3 sp = new Vector3(0, 1 , 12f);
                Instantiate(chaser, sp, Quaternion.identity);
                alive = true;
            }
        }
    }
}
