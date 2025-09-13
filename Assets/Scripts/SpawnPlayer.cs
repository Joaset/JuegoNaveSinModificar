using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] GameObject nave;
    [SerializeField] GameObject nave2;
    [SerializeField] Transform spawnPlayer;

    void Start()
    {
        if (GameManager.Instance.jugador == 1)
        {
            Instantiate(nave,spawnPlayer.position, nave.transform.rotation);
        }

        if (GameManager.Instance.jugador == 2)
        {
            Instantiate(nave2, spawnPlayer.position, nave2.transform.rotation);
        }
    }
}
