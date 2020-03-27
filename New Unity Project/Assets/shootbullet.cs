using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootbullet : MonoBehaviour
{

    private float timer;
    private float starttimer;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        timer = starttimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
          //  Instantiate(bullet, transform.position, Quaternion.identity);
         //  timer = starttimer;
        }
        else
        {
            timer -= Time.deltaTime;
        }

    }
}
