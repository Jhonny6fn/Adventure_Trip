using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class EnemyScript : MonoBehaviour
{
    private Animator myanimator;

    private static bool sonidoMuerte;

    private bool OnnOff;

    private AudioSource music;

    public AudioClip FXMuerte;

    private void Awake()
    {
        music = GetComponent<AudioSource>();

        sonidoMuerte = false;
    }

    void Start()
    {
        myanimator = GetComponent<Animator>();

        OnnOff = true;
    }

    void Update()
    {
        myanimator.Play("Animation_Run");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Disparo")
        {
            Destroy(this.gameObject);
            AudioSource.PlayClipAtPoint(FXMuerte, transform.position, 0.2f);
            sonidoMuerte = false;
        }

        if (collision.tag == "Player")
        {
            collision.gameObject.GetComponent<vida>().Vida = collision.gameObject.GetComponent<vida>().Vida - 1;
        }
    }
}
