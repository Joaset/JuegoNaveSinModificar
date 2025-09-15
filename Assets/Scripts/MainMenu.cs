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
        //SceneManager.LoadScene(1);
        var pixelEffect = FindObjectOfType<PixelateEffect>();
        if (pixelEffect != null)
        {
            int nextIndex = SceneManager.GetActiveScene().buildIndex + 1;
            pixelEffect.PlayPixelateEffect(40f, 0.5f, nextIndex);
        }
        else
        {
            // Fallback: carga directa si el efecto no está presente
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
