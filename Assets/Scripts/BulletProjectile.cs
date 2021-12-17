using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    private Rigidbody bulltRigidbody;
    [SerializeField] private float speed = 10f;

    private void Awake()
    {
        bulltRigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {

        bulltRigidbody.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
