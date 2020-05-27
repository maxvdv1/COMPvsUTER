using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class p1levens : MonoBehaviour
{

public GameObject levens;
   

   
    void Update()
        {
            levens.GetComponent<Text>().text = movementplayer1.livesp1string;
        }
}
