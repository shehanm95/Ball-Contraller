using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    GameObject player;
    float xpos;

    Vector3 pos;
    void Start()
    {

        player = GameObject.Find("PLAYER");
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            xpos = player.transform.position.x;
        float x = xpos + 4;

        transform.position = new Vector3(x, 0, -10);
        }
       // print(xpos);
    }
}
