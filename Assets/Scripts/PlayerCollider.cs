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
        }
        if (collision.gameObject.CompareTag("EnemyCuracion"))
        {
            GameManager.Instance.vidaMaxima += 25f;
        }
    }
}
