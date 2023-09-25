using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class vida : MonoBehaviour
{
    public float Vida;
    public Slider barraVida;
    
    void Update()
    {
        barraVida.value = Vida;
        if (Vida <= 0)
        {
            SceneManager.LoadScene("Menu_Inicio");
            Destroy(gameObject);
        }
    }
}
