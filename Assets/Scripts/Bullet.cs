using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rigi;
    public float speed = 8.0f;

    void Start()
    {
        rigi = GetComponent<Rigidbody>();
        rigi.velocity = transform.forward * speed; 
        Destroy(gameObject, 3.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<PlayerController>()?.Die();
        }
    }
}
