using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pacdot : MonoBehaviour
{
    public AudioSource aAudio;

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "Pac-man")
        {
            Destroy(gameObject);
            aAudio.Play();
        }

    }
}

