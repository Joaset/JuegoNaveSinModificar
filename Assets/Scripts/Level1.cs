using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    private bool transitionStarted = false;

    void Start()
    {
        AudioManager.Instance.PlayAudio(AudioManager.Instance.backgroundMusic);
    }

    void Update()
    {
        if (!transitionStarted && GameManager.Instance.puntajeTotal >= 250)
        {
            transitionStarted = true;

            var pixelEffect = FindObjectOfType<PixelateEffect>();
            if (pixelEffect != null)
            {
                int nextIndex = SceneManager.GetActiveScene().buildIndex + 1;
                pixelEffect.PlayPixelateEffect(40f, 0.7f, nextIndex);
            }
            else
            {
                // Fallback: carga directa si el efecto no est� presente
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

    private string GetNextSceneName()
    {
        // Pod�s usar esto si quer�s por nombre
        int nextIndex = SceneManager.GetActiveScene().buildIndex + 1;
        return SceneManager.GetSceneByBuildIndex(nextIndex).name;
    }
}

