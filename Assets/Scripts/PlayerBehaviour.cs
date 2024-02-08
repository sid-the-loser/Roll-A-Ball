using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private float speed = 0.1f;
    [SerializeField] private AudioClip coinSfx;
    private int _score;
    private Vector3 _velocity;
    private Rigidbody _rb;
    private AudioSource _audSrc;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _audSrc = GetComponent<AudioSource>();
        _audSrc.clip = coinSfx;
    }

    private void Update()
    {
        _velocity.x = Input.GetAxis("Horizontal");
        _velocity.z = Input.GetAxis("Vertical");

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
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
            _audSrc.Play();
            _score++;
            Destroy(other.gameObject);
        }
    }
}
