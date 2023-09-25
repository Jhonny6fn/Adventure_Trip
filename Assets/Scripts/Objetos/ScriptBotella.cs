using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBotella : MonoBehaviour
{
    public static bool sonidoBotella;

    private bool OnnOff;

    private AudioSource Music;

    public AudioClip FXbotella;

    private void Awake()
    {
        Music = GetComponent<AudioSource>();

        sonidoBotella = false;
    }

    void Start()
    {
        OnnOff = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.GetComponent<vida>().Vida = collision.gameObject.GetComponent<vida>().Vida + 1;

            Destroy(this.gameObject);

            AudioSource.PlayClipAtPoint(FXbotella, transform.position, 0.8f);
            sonidoBotella = false;
        }
    }
}
