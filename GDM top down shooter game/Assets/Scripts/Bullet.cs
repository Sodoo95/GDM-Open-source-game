using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private MouseLocationDetector mouseCursor;
    private GunScript gunScript;
    [SerializeField] private float speed = 1, distance, range = 100;
    private GameObject bulletSpawner;
    private Vector3 dir;

    private void Awake()
    {
        gunScript = GameObject.Find("Gun").GetComponent<GunScript>();
        dir = gunScript.dir;
        bulletSpawner = GameObject.Find("BulletSpawner");
        mouseCursor = GameObject.Find("Player").GetComponent<MouseLocationDetector>();
        rigidbody = transform.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {

        transform.position += dir * speed *Time.deltaTime;
        distance = Vector3.Distance(bulletSpawner.transform.position, transform.position);

        if (distance > range) Destroy(gameObject);
    }
}
