using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{


    Rigidbody arrowBody;
    private float levensDuur = 2f;
    private float timer;
    private bool hit = false;

            private void Start()
            {
                arrowBody = GetComponent<Rigidbody>();
                transform.rotation = Quaternion.LookRotation(arrowBody.velocity);
            }

           
            void Update()
            {
                if (!hit)
                {
                    transform.rotation = Quaternion.LookRotation(arrowBody.velocity);
                }
            }

            private void OnCollisionEnter(Collision collision)
            {
                hit = true;
            }
}
