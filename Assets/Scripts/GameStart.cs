using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        AudioManager.Instance.StopAudio(AudioManager.Instance.backgroundMusic);
    }

    public void SeleccionarJugador(float nave)
    {
        GameManager.Instance.jugador = nave;    
    }
}
