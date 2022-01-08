using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigi;

    public float speed = 5.0f;

    void Start()
    {
        rigi = GetComponent<Rigidbody>();       
    }

    // Update is called once per frame
    void Update()
    {
        float velX = Input.GetAxis("Horizontal");
        float velZ = Input.GetAxis("Vertical");

        rigi.velocity = new Vector3(velX * speed, 0, velZ * speed);
    }

    public void Die()
    {
        gameObject.SetActive(false);
        GameObject.Find("GameManager").GetComponent<GameManager>().GameOver();
    }
}
