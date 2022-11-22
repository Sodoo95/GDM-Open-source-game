using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class GunScript : MonoBehaviour
{
    private MouseLocationDetector mouseLocationDetector;
    private Vector3 relativePosition;
    private float angle;
    [SerializeField] private Bullet bullet;
    public Transform bulletSpawner;
    public Vector3 dir;

    private void Awake()
    {
        mouseLocationDetector = transform.parent.GetComponent<MouseLocationDetector>();
        bulletSpawner = transform.GetChild(0).transform;
    }
    private void Update()
    {
        relativePosition = mouseLocationDetector.worldPosition - transform.position;
        angle = Mathf.Atan2(relativePosition.y, relativePosition.x) * Mathf.Rad2Deg;
        
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        dir = (mouseLocationDetector.clickedPosition - bulletSpawner.transform.position).normalized;

        if (Input.GetMouseButton(0)) Fire();

    }

    void Fire()
    {
        Instantiate(bullet, bulletSpawner.position, Quaternion.identity);
    }
}
