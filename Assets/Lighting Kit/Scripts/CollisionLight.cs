using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CollisionLight : MonoBehaviour
{
    private new Light light;
    private Collider lightCollider;
    private Rigidbody m_Rigidbody;
    AudioSource audioSource = null;
    [SerializeField] AudioClip SFX = null;
    [SerializeField] ParticleSystem DestroyParticle = null;
    [SerializeField] GameObject Art = null;
    [SerializeField] private LayerMask CollidableObjects = 1;
    [SerializeField] Boolean KeepInMemory = false;

    void Awake()
    {
            audioSource = GetComponent<AudioSource>();
            m_Rigidbody = GetComponent<Rigidbody>();
            light = GetComponent<Light>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Detect collision
        if (collision.gameObject.layer == 0)
        {
            GetComponent<Light>().enabled = false;
            if (SFX != null)
            {
                audioSource.clip = SFX;
                audioSource.Play();
            }
            Instantiate(DestroyParticle, light.transform.position, Quaternion.identity);
        }
        //Only disable light
        if(KeepInMemory == true)
        {
            Art.gameObject.SetActive(false);
        }
        else
        {
            //Destroy this light completely
            Art.gameObject.SetActive(false);
            StartCoroutine(DestroyLight());
        }
    }

    IEnumerator DestroyLight()
    {
        yield return new WaitForSeconds(1);
        this.gameObject.SetActive(false);
    }

}
