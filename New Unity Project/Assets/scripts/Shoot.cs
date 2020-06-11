using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Camera cam;
    public GameObject arrowPf;
    public Transform arrowSpawn;
    public float shootForce = 20f;

    private float timeBtwShots;
    public float startTimeBtwShots;


        private void Start()
            {
                //timeBtwShots = Random.Range(1f, 2f);
        timeBtwShots = startTimeBtwShots;
            }

        void Update()
            {
                if (timeBtwShots <= 0)
                {
                     GameObject go = Instantiate(arrowPf, arrowSpawn.position, Quaternion.identity);
                     Rigidbody rb = go.GetComponent<Rigidbody>();
                     rb.velocity = cam.transform.forward * shootForce;
                    timeBtwShots = startTimeBtwShots;
                    
                 }
                else
                {
                    timeBtwShots -= Time.deltaTime;
                }
            }
 }
