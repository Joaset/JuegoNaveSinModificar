using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        AudioManager.Instance.PlayAudio(AudioManager.Instance.backgroundMusic);
    }
    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }
}
