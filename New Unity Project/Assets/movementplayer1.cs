﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementplayer1 : MonoBehaviour
{
    public static float livesp1 = 100;
    public float movement;
    public float speedup = 30f;
    public static string livesp1string;
    public Transform player2;

    public GameObject panelp1wins;
    //private float wachtTijd;
    //public float LoopTijd;

    public Transform[] places;
    private int randomPlace;

    private Transform player1;

    // Start is called before the first frame update
    void Start()
    {
        randomPlace = Random.Range(0, places.Length);

    }

    // Update is called once per frame
    void Update()
    {
        livesp1string = livesp1.ToString();
        if (collis.reachedmountain)
        {
            transform.position = Vector3.MoveTowards(transform.position, places[randomPlace].position, speedup * Time.deltaTime);

            if (Vector3.Distance(transform.position, places[randomPlace].position) < 80f)
            {
                //Debug.Log("RAndom punt bereikt!");
                //transform.position = Vector3.MoveTowards(transform.position, player2.position, speedup * Time.deltaTime);

                collis.reachedmountain = false;

            }

        } else if (collis.reachedmountain == false)
        {


            transform.position = Vector3.MoveTowards(transform.position, player2.position, movement * Time.deltaTime);

            if (Vector3.Distance(transform.position, player2.position) < 90f)
            {
             //   Debug.Log("player 2 bereikt!");
                randommovement.lives = 0;
                panelp1wins.SetActive(true);
                Time.timeScale = 0;
            }


        }

     
}

    
}