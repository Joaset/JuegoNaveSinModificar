using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollider : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameManager.Instance.vidaMaxima -= 25f;
            if (GameManager.Instance.vidaMaxima <= 0)
            {
                SceneManager.LoadScene(6);
                AudioManager.Instance.StopAudio(AudioManager.Instance.backgroundMusic);
                Destroy(gameObject);
            }
        }
    }
}
