using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveMechanics : MonoBehaviour
{

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Interactive")
        {
            Debug.Log("hitsomething");
        }
    }

}