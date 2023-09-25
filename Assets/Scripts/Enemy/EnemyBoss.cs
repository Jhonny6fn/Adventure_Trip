using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class EnemyBoss : MonoBehaviour
{
    private Animator myanimator;

    private static bool sonidoMuerte;

    private bool OnnOff;

    private AudioSource music;

    public AudioClip FXMuerte;

    public int VidaEnemy = 30;

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
        myanimator.Play("Animation_Idle");

        if (VidaEnemy <= 0)
        {
            Destroy(this.gameObject);
            AudioSource.PlayClipAtPoint(FXMuerte, transform.position, 0.2f);
            sonidoMuerte = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Disparo")
        {
            VidaEnemy = VidaEnemy - 1;
        }

        if (collision.tag == "Player")
        {
            collision.gameObject.GetComponent<vida>().Vida = collision.gameObject.GetComponent<vida>().Vida - 1;
        }
    }
}
