using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private Transform firePoint1;
    [SerializeField] private Transform firePoint2;

    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject bullet2;
    private bool puedeDisparar;
    [SerializeField] private float tiempoEntreAtaques;
    [SerializeField] private float tiempoSiguienteAtaque;

    private bool disparoDoble = false;

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
        if (!disparoDoble)
        {
            if (Input.GetButtonDown("Jump") && tiempoSiguienteAtaque <= 0 && puedeDisparar == true)
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
            AudioManager.Instance.PlayAudio(AudioManager.Instance.shoot);
            tiempoSiguienteAtaque = tiempoEntreAtaques;
        }
        }
        else
        {
            if (Input.GetButtonDown("Jump") && tiempoSiguienteAtaque <= 0 && puedeDisparar == true)
            {
                Instantiate(bullet, firePoint1.position, firePoint1.rotation);
                Instantiate(bullet2, firePoint2.position, firePoint2.rotation);
                AudioManager.Instance.PlayAudio(AudioManager.Instance.shoot);
                tiempoSiguienteAtaque = tiempoEntreAtaques;
            }
        }
        
    }

    public void ActivarDisparoDoble(float duracion)
    {
        disparoDoble = true;
        CancelInvoke("DesactivarDisparoDoble");
        Invoke("DesactivarDisparoDoble", duracion);
    }

    void DesactivarDisparoDoble()
    {
        disparoDoble = false;
    }
}
