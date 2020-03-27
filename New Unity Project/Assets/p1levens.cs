using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class p1levens : MonoBehaviour
{

    public GameObject levens;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        levens.GetComponent<Text>().text = movementplayer1.livesp1string;
    }
}
