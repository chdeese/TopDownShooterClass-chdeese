using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFacingScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //get the camera's transform.
        Transform cam = Camera.main.transform;
        //look in the direction the camera is facing. (reverse rotation)
        transform.LookAt(transform.position + cam.forward);
    }
}
