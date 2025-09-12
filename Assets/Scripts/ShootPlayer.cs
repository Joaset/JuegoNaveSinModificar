using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject bullet;
    private bool puedeDisparar;
    [SerializeField] private float tiempoEntreAtaques;
    [SerializeField] private float tiempoSiguienteAtaque;

    void Start()
    {
        puedeDisparar = true;
    }

    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (tiempoSiguienteAtaque > 0)
        {
            tiempoSiguienteAtaque -= Time.deltaTime;
        }
        if (Input.GetButtonDown("Jump") && tiempoSiguienteAtaque <= 0 && puedeDisparar == true)
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
            AudioManager.Instance.PlayAudio(AudioManager.Instance.shoot);
            tiempoSiguienteAtaque = tiempoEntreAtaques;
        }
    }
}
