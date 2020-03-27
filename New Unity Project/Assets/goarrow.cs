using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goarrow : MonoBehaviour
{
    
    public float speed = 100f;
    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position, speed * Time.deltaTime);
        //Debug.Log("");
    }
}
