using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");


    }

    // Update is called once per frame
    void Update()
    {
        var playerPos = player.transform.position;
        var cameraPos = this.transform.position;

        if (playerPos.y < 0)
        {
            cameraPos.x = playerPos.x;
            cameraPos.y = playerPos.y;
        }
        this.transform.position = cameraPos;
    }
}
