using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collis : MonoBehaviour
{

    public float speedup = 30f;

    
    public static bool reachedmountain = false;
    private Transform player2;

   
    void Start()
    {
       

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("player2 reached mountain");
        reachedmountain = true;
        //Debug.Log(reachedmountain);


       

        

        
    }


}
