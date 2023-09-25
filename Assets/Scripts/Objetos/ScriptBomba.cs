using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ScriptBomba : MonoBehaviour
{
    public static bool sonidoBomba;
    private bool OnnOff;
    private AudioSource Music;
    public AudioClip FXbomba;

    private void Awake()
    {
        Music = GetComponent<AudioSource>();
        sonidoBomba = false;
    }

    void Start()
    {
        OnnOff = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.GetComponent<vida>().Vida = collision.gameObject.GetComponent<vida>().Vida - 1; 

            Destroy(this.gameObject);

            AudioSource.PlayClipAtPoint(FXbomba, transform.position, 1f);
            sonidoBomba = false;
        }

        if (collision.tag == "Terreno")
        {
            Destroy(this.gameObject);
        }

        if (collision.tag == "Platforms")
        {
            Destroy(this.gameObject);
        }

        if (collision.tag == "Roca")
        {
            Destroy(this.gameObject);
        }
    }
}
