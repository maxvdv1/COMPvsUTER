using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerap2 : MonoBehaviour
{
    public float cameraDistOffset = 10;
    private Camera mainCamera;
    private GameObject player;

    // Use this for initialization
    void Start()
    {
        mainCamera = GetComponent<Camera>();
        player = GameObject.FindGameObjectWithTag("player2");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerInfo = player.transform.transform.position;
        mainCamera.transform.position = new Vector3(playerInfo.x, playerInfo.y, playerInfo.z - cameraDistOffset);
    }
}
