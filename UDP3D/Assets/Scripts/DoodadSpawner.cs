using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoodadSpawner : MonoBehaviour
{
    public GameObject[] stuff;
    private float spawnCd;
    private float timer;
    private float[] points = {-10f, 10f};
    void Start()
    {
        spawnCd = 4f;
        timer = 3f;
        Random.InitState((int)Time.time);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnCd)
        {
            timer = 0f;
            GameObject obj = stuff[Random.Range(0, stuff.Length)];
            float x = points[Random.Range(0,2)];
            if (obj.tag == "Building")
            {
                x *= 3f;
            }
            Vector3 sp = new Vector3(x, obj.transform.position.y ,-120);
            Instantiate(obj, sp, Quaternion.identity);
        }
    }
}
