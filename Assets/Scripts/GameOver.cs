using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void Start()
    {
        AudioManager.Instance.PlayAudio(AudioManager.Instance.loseMusic);
    }

    public void CambiarMenu()
    {
        SceneManager.LoadScene(0);
    }
}
