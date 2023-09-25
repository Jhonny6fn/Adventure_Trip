using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ScenaJuego()
    {
        SceneManager.LoadScene("Nivel");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
