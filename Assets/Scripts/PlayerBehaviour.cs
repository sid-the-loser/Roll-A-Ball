using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private float speed = 0.1f;
    private int _score = 0;
    private Vector3 _velocity = new Vector3();
    private Rigidbody _rb;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _velocity.x = Input.GetAxis("Horizontal");
        _velocity.z = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        _rb.AddForce(_velocity*speed);
    }

    public int GetScore()
    {
        return _score;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            _score++;
            Destroy(other.gameObject);
        }
    }
}
