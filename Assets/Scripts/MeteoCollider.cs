using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoCollider : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.vidaMaxima -= 25f;
        }


        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
