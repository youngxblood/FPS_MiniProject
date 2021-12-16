using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    private Rigidbody bulltRigidbody;

    private void Awake()
    {
        bulltRigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        float speed = 10f;
        bulltRigidbody.velocity = transform.forward * speed * Time.deltaTime;
    }
}
