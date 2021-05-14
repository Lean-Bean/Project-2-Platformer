using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Script by Tommy
public class PlatformTimer : MonoBehaviour
{
    public GameObject objectToToggle;

    private float time = 0f;
    public float timer = 2f;
    
    public bool ActivateObjectAfterTimer;
    public bool DeactivateObjectAfterTimer;

    void Update()
    {
        if (ActivateObjectAfterTimer == true)
        {
            if (!objectToToggle.active)
            {
                time += Time.deltaTime;
                if (time > timer)
                {
                    time = 0f; //reset time
                    objectToToggle.SetActive(true);
                }
            }
        }
        if (DeactivateObjectAfterTimer == true)
        {
            if (objectToToggle.active)
            {
                time += Time.deltaTime;
                if (time > timer)
                {
                    time = 0f; //reset time
                    objectToToggle.SetActive(false);
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (objectToToggle.active == true)
        {
            objectToToggle.SetActive(false);
        }
        else
        {
            objectToToggle.SetActive(true);
        }
    }
}
