using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMover : MonoBehaviour
{
    public MovePlatform script;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Green Key")
        {
            script.enabled = true;
        }
    }

}
