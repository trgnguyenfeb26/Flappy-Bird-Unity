using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnn : MonoBehaviour
{
    public GameObject pipe;
    public float maxTime;
    public float height;
    float timer;
    public void Update()
    {
        if (timer > maxTime)
        {
            GameObject tmp = Instantiate(pipe, new Vector3(transform.position.x, transform.position.y+ Random.Range(-height, height),0),Quaternion.identity);
            Destroy(tmp, 10f);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
