using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        AudioManager.Instance.PlayAudio(AudioManager.Instance.backgroundMusic);
        GameManager.Instance.puntajeTotal = 0;
        GameManager.Instance.vidaMaxima = 100;
        GameManager.Instance.jugador = 0;
    }
    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }
}
