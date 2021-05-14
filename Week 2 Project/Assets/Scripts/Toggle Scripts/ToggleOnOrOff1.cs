using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOnOrOff1 : MonoBehaviour
{
    public GameObject objectToToggle;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Green Key 2")
        {
            if(objectToToggle.active == true)
            {
                objectToToggle.SetActive(false);
            }
            else
            {
                objectToToggle.SetActive(true);
            }
        }
    }


}
