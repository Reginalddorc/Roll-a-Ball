using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
  
    public void Juego()
    {
        SceneManager.LoadScene("Juego");
    }

    public void Opcion(string ControlJuego)
    {
        SceneManager.LoadScene(ControlJuego);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
