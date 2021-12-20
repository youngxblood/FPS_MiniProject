using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    private Rigidbody bulltRigidbody;
    [SerializeField] private float speed = 10f;
    [SerializeField] private Transform hitVFX;
    [SerializeField] private Transform missVFX;
    // [SerializeField] private GameObject 

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

        if(other.GetComponent<BulletTarget>() != null)
        {
            Instantiate(hitVFX, transform.position, Quaternion.identity);
        } else
        {
            Instantiate(missVFX, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
