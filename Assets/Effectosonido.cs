using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effectosonido : MonoBehaviour
{
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            audioSource.Play();
        }
    }
}
