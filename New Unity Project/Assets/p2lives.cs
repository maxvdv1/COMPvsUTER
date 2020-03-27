using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p2lives : MonoBehaviour
{
    public GameObject levensp2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        levensp2.GetComponent<Text>().text = randommovement.livesp2;
    }
}
