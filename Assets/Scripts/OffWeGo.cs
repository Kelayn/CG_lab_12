using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffWeGo : MonoBehaviour
{

    public GameObject gObj;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            gObj.GetComponent<Renderer>().enabled = !gObj.GetComponent<Renderer>().enabled;
        }
    }
}
