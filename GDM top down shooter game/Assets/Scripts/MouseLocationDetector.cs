using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLocationDetector : MonoBehaviour
{
    // Mousenii world space positiong bai bolgoj heregleh bolhoor public bolgson. 
    // public Vector3 worldPosition { get; private set; } gj baga zgr heterhi publiciin hyanah gsn bolowch Z valuegaas bolood hyanaj bolohgu bolson. yer n tgj bgad yanzalna.
    public Vector3 worldPosition;
    public Vector3 clickedPosition;

    private void Update()
    {
        // Simplest way to find mouse position on world space. 
        worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Z value camera-in value dagaad bga uchraas shuud hasaad 0lej bgaan.
        worldPosition.z = worldPosition.z - Camera.main.transform.position.z;
        
        //
        if (Input.GetMouseButton(0)) clickedPosition = worldPosition;
    }


}
