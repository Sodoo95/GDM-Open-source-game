using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour
{
    private MouseLocationDetector mouseLocationDetector;

    private void Awake()
    {
        // Toglogchiin mouse locationiig hiij bga scriptiig cursoriiha gameobjectiin scriptruu duudj bga ni.
        mouseLocationDetector = transform.parent.GetComponent<MouseLocationDetector>();
    }
    private void LateUpdate()
    {
        // Tgd mouseni world space positiong cursoriin position bolgoj uurchilj bga ni.
        this.transform.position = mouseLocationDetector.worldPosition;
    }
}
