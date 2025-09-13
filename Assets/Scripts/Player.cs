using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    void Update()
    {
        if (GameManager.Instance.vidaMaxima <= 0)
        {
            SceneManager.LoadScene(6);
            AudioManager.Instance.StopAudio(AudioManager.Instance.backgroundMusic);
            AudioManager.Instance.StopAudio(AudioManager.Instance.boss);
            AudioManager.Instance.StopAudio(AudioManager.Instance.backgroundBoss);
            Destroy(gameObject);
        }
    }
}
