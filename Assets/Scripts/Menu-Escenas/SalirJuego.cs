using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirJuego : MonoBehaviour
{
    public void SalirdelJuego()
    {
        SceneManager.LoadScene("Menu_Inicio");
    }
}
