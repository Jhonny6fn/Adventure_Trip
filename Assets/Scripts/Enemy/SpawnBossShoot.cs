using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBossShoot : MonoBehaviour
{
    public GameObject Disparo;
    public float primero;
    public float repeticiones;
    int maxDisparos = 1;
    int DisparosMaximo = 0;

    void Start()
    {
        InvokeRepeating("spawnShoot", primero, repeticiones);
    }

    private void spawnShoot()
    {
        if (maxDisparos > DisparosMaximo)
        {
            Instantiate(Disparo, transform.position, transform.rotation);
        }
    }
}
