using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            AudioManager.Instance.PlayAudio(AudioManager.Instance.enemydead);
        }


        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            AudioManager.Instance.PlayAudio(AudioManager.Instance.enemydead);
            if (GameManager.Instance.puntajeTotal == 100)
            {
                GetComponent<SpawnItem>().CrearItemVida();
            }
        }
    }
}
