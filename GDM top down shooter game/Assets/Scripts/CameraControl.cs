using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private float zoomSpeed;
    private void Update()
    {
        // Simplest mouse wheel zoom in n out.                                       // Giving boundry to camera zoom. 
        if (Input.GetAxis("Mouse ScrollWheel") != 0f) Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - Input.GetAxis("Mouse ScrollWheel") * zoomSpeed, 1, 15);
        
        

    }
}
