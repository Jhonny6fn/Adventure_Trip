using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject bomba;
    public int xPos;
    public int Contador;
    public float espera = 0.5f;

    public void Start()
    {
        StartCoroutine(BombaDrop());
    }

    IEnumerator BombaDrop()
    {
        while (Contador >= 0)
        {
            xPos = Random.Range(20, 99);
            Instantiate(bomba, new Vector3(xPos, 10, 0), Quaternion.identity);
            yield return new WaitForSeconds(espera);
            Contador += 1;
        }
    }
}
