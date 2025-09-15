using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3 : MonoBehaviour
{
    void Update()
    {
        if (GameManager.Instance.puntajeTotal == 2000)
        {
            AudioManager.Instance.StopAudio(AudioManager.Instance.backgroundMusic);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
