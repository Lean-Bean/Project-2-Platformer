using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMover1 : MonoBehaviour
{
    public MovePlatform script;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Green Key 2")
        {
            script.enabled = true;
        }
    }

}
