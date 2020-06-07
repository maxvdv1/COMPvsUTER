using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Camera cam;
    public GameObject arrowPf;
    public Transform arrowSpawn;
    public float shootForce = 20f;


   
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                 GameObject go = Instantiate(arrowPf, arrowSpawn.position, Quaternion.identity);
                 Rigidbody rb = go.GetComponent<Rigidbody>();
                 rb.velocity = cam.transform.forward * shootForce;
            }
        }
 }
