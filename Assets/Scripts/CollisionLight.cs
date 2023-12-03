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
        if (GetComponent<Light>() == null)
        {
            audioSource = GetComponent<AudioSource>();
            light = GetComponent<Light>();
            m_Rigidbody = GetComponent<Rigidbody>();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Detected!");
        if (collision.gameObject.layer == 1)
        {
            Debug.Log("Layer Check");
            Destroy(GetComponent<Light>());
            if (audioSource != null && SFX != null)
            {
                audioSource.clip = SFX;
                audioSource.Play();
            }
            DestroyParticle.Play();
            Debug.Log("Light Destroyed!");
        }
    }
}
