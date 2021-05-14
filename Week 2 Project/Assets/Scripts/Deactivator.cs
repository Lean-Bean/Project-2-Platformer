using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivator : MonoBehaviour

{
    public MovePlatform script;
    // Start is called before the first frame update
    void Start()
    {
    
        script.enabled = false;

    }

}
