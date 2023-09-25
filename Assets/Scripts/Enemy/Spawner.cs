using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;
    public float primero;
    public float repeticiones;
    int maxEnemigos = 0;
    public int enemigosMaximo;

    void Start()
    {
        InvokeRepeating("spawnenemy", primero, repeticiones);
    }

    private void spawnenemy()
    {
        if (maxEnemigos < enemigosMaximo)
        {
            Instantiate(Enemy, transform.position, transform.rotation);
            maxEnemigos = maxEnemigos + 1;
        }
    }
}
