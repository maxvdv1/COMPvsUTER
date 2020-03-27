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
    //private float wachtTijd;
    //public float LoopTijd;
    private float timeBtwShots;
    public float startTimeBtwShots;
    public Camera p1;
    //private LineRenderer laser;
    public GameObject target;
    //public Transform bowEnd;
    public float range = 100f;
    private Transform player1;
    public Transform xcam;
    //private WaitForSeconds shotDuration = new WaitForSeconds(0.7f);
    // Start is called before the first frame update
    void Start()
    {
        randomPlace = Random.Range(0, places.Length);
        timeBtwShots = Random.Range(1f, 2f);
        // laser = GetComponent<LineRenderer>();
        

    }


    

    void Update()
    {
        livesp2 = lives.ToString();
        transform.position = Vector3.MoveTowards(transform.position, places[randomPlace].position, movespeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, places[randomPlace].position) < 20f)
        {
      
                randomPlace = Random.Range(0, places.Length);
            

           
        }

        float distanceToEnemy = Vector3.Distance(transform.position, target.transform.position); //kan ook target

        //Vector3 dir = player1.position - transform.position;
        //Quaternion lookRotation = Quaternion.LookRotation(dir);
        //Vector3 rotation = lookRotation.eulerAngles;
        //xcam.rotation = Quaternion.Euler(0f, 0f, rotation.z);


        if (distanceToEnemy <= range)
        {
            Debug.Log("enemy spotted");
            if (timeBtwShots <= 0)
            {
                timeBtwShots = Random.Range(1f, 2f);

                Instantiate(arrow, transform.position, Quaternion.identity);
                Rigidbody rigidArrow = arrow.GetComponent<Rigidbody>();
                rigidArrow.AddForce(Vector3.forward);
            }
            else { timeBtwShots -= Time.deltaTime;  }

            // p1.transform.forward = target.transform.position.x;
        }








        //player1 = GameObject.FindGameObjectWithTag("player1").GetComponent<Transform>();
        ////var target = new Vector3(player1.position.x, player1.position.y, player1.position.z) - transform.position;

        //if (timeBtwShots <= 0)
        //{

        //    //Instantiate(arrow, transform.position, Quaternion.identity);
        //   // Debug.Log("arrow gespawned");
        //    //timeBtwShots = Random.Range(1f, 2f);
        //    //RaycastHit hit;
        //    //if (Physics.Raycast(p1.transform.position, p1.transform.forward, out hit, range))
        //    //{

        //    //    Debug.Log(hit.transform.name);


        //    //  if(hit.transform.name == "playerone")
        //    //    {

        //    //      //  Debug.Log(movementplayer1.livesp1);
        //    //        movementplayer1.livesp1 -= 10;
        //    //    }
        //    //    else
        //    //    {

        //    //    }
        //    //}
        //}
        //else
        //{
        //    timeBtwShots -= Time.deltaTime;

        //}




    }


    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}

