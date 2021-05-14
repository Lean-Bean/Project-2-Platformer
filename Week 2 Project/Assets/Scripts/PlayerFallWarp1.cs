using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallWarp1 : MonoBehaviour
{
    public GameObject warpPoint;
    public float teleportFloorLevel;
    public GameObject cube;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= teleportFloorLevel)
        {

            transform.position = warpPoint.transform.position;

        }
    }
}
