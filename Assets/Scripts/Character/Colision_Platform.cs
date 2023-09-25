using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Colision_Platform : MonoBehaviour
{
    public static bool sonidoPlataforma;

    private bool OnnOff;

    private AudioSource Music;

    public AudioClip FXplataforma;

    private void Awake()
    {
        Music = GetComponent<AudioSource>();

        sonidoPlataforma = false;
    }

    void Start()
    {
        OnnOff = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platforms")
        {
            AudioSource.PlayClipAtPoint(FXplataforma, transform.position, 0.2f);
            sonidoPlataforma = false;
        }
            this.transform.parent = collision.gameObject.transform;
            
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        this.transform.parent = null;
    }
}
