using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    void Start()
    {
        AudioManager.Instance.PlayAudio(AudioManager.Instance.backgroundMusic);
    }

    void Update()
    {
        if (GameManager.Instance.puntajeTotal == 250)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
