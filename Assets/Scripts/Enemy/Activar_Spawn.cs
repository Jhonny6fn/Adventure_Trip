using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar_Spawn : MonoBehaviour
{
    public GameObject Spawn;
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Spawn.SetActive(true);
        }
    }
}
