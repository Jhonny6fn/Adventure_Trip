using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_Boss : MonoBehaviour
{
    float speed;

    void Update()
    {
        speed = Random.Range(3, 12);
        transform.Translate(Vector3.left * Time.deltaTime * speed, Space.Self);
        Debug.Log(speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.GetComponent<vida>().Vida = collision.gameObject.GetComponent<vida>().Vida - 1;
            destroyme();
        }
    }

    public void destroyme()
    {
        Destroy(this.gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
