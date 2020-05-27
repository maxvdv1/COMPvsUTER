using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootbullet : MonoBehaviour
{

    private float timer;
    private float starttimer;
    public GameObject bullet;


  
        void Start()
        {
            timer = starttimer;
        }

    
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
