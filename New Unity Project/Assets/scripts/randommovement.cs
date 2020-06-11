using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randommovement : MonoBehaviour
{

    public static float lives = 100;
    public float movespeed;

    public Transform[] places;
    private int randomPlace;
    public GameObject arrow;
    public static string livesp2;
    
    private float timeBtwShots;
    public float startTimeBtwShots;
    public Camera p1;
   
    public GameObject target;
    
    public float range = 100f;
    private Transform player1;
    public Transform xcam;
    public float followingp1speed = 20;
    public Transform FollowPos = null;


    void Start()
        {
            randomPlace = Random.Range(0, places.Length);
            timeBtwShots = Random.Range(1f, 2f);
        
        }




    void Update()
        {
            float distanceToEnemy = Vector3.Distance(transform.position, target.transform.position); //kan ook target
            livesp2 = lives.ToString();
            transform.position = Vector3.MoveTowards(transform.position, places[randomPlace].position, movespeed * Time.deltaTime);


                if (Vector3.Distance(transform.position, places[randomPlace].position) < 20f)
                {
                    randomPlace = Random.Range(0, places.Length);
                }



                if (distanceToEnemy <= range)
                {

                    Debug.Log("enemy spotted");

                    this.transform.LookAt(FollowPos); //aim on player

                }



        }


}

