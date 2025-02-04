using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void CargarMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void CargarPartida()
    {
        SceneManager.LoadScene(1);
    }

    public void SalirJuego()
    {
        Debug.Log("Saliendo del juego");
        Application.Quit();
    }
}
