using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    Animator anim;
    bool isCollided = false;
    bool isOpened = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isCollided && !isOpened)
        {
            Debug.Log("OPEN");
            anim.SetTrigger("DoorOpenTrigger");  
        }

        if (Input.GetKeyUp(KeyCode.E) && isCollided)
        {
            anim.ResetTrigger("DoorCloseTrigger");
            anim.ResetTrigger("DoorOpenTrigger");
            isOpened = !isOpened;

        }
 
        if (Input.GetKeyDown(KeyCode.E) && isCollided && isOpened)
        {
            Debug.Log("CLOSE");
            anim.SetTrigger("DoorCloseTrigger");  
       }
    }

    void OnCollisionEnter(Collision collision)
    {
       isCollided = true;
    }

    void OnCollisionExit(Collision collision)
    {
        isCollided = false;
    }
}
