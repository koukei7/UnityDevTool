using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionLight : MonoBehaviour
{
    private new Light light;
    private Collider lightCollider;
    private Rigidbody m_Rigidbody;
    AudioSource audioSource = null;
    [SerializeField] AudioClip SFX = null;
    [SerializeField] ParticleSystem DestroyParticle = null;
    [SerializeField] private LayerMask CollidableObjects = 1;



    void Awake()
    {
            audioSource = GetComponent<AudioSource>();
            m_Rigidbody = GetComponent<Rigidbody>();
            light = GetComponent<Light>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Detected!");
        if (collision.gameObject.layer == 0)
        {
            GetComponent<Light>().enabled = false;
            if (SFX != null)
            {
                audioSource.clip = SFX;
                audioSource.Play();
                Debug.Log("Audio Feedback");
            }
            DestroyParticle.Play();
            Debug.Log("Particle Feedback");
        }
        Debug.Log("Light Destroyed");
    }
}
