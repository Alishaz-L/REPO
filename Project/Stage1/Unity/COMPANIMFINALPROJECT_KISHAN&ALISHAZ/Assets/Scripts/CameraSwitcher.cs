using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class CameraSwitcher : MonoBehaviour
{
    public Camera[] cameras; //Array to hold all cameras 
    private int currentCameraIndex = 0; // Tracks the active camera index 
    private void Start()
    {
        //Ensure only the first camera is active at the start
        for(int i = 0; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(i==currentCameraIndex);
        }
    }
    private void Update()
    {
        //check for key press(space to switch cameras)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchCamera(); 
        }
    }
    void SwitchCamera()
    {
        // Deactivate current Camera
        cameras[currentCameraIndex].gameObject.SetActive(false);
        //Move to the next camera in the array
        currentCameraIndex=(currentCameraIndex+1)%cameras.Length;
        //Activate the new current camera
        cameras[currentCameraIndex].gameObject.SetActive(true);
    }
}
