using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenúInicial : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(2);
    }

    public void Salir()
    {
        Debug.Log("Salir del juego ");
        Application.Quit();
    }

    public void Opciones()
    {
        SceneManager.LoadScene(1);
    }

    public void SalirMenú()
    {
        SceneManager.LoadScene(0);

    }

    public void Volver()
    {
        SceneManager.LoadScene(0);
    }
}
