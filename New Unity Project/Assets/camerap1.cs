using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerap1 : MonoBehaviour
{

        public float cameraDistOffset = 10;
        private Camera mainCamera2;
        private GameObject player1;

        // Use this for initialization
        void Start()
        {
            mainCamera2 = GetComponent<Camera>();
            player1 = GameObject.FindGameObjectWithTag("player1");
        }

        // Update is called once per frame
        void Update()
        {
            Vector3 playerInfo = player1.transform.transform.position;
            mainCamera2.transform.position = new Vector3(playerInfo.x, playerInfo.y, playerInfo.z - cameraDistOffset);
        }
    

}
