using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteo : MonoBehaviour
{
    [SerializeField] private GameObject meteoPrefab; // Asignar el prefab en el Inspector

    void Start()
    {
        StartCoroutine(SpawnMeteoro());
    }

    public void CreateEnemy()
    {
        Camera cam = Camera.main;

        // Obtener l�mites reales en X
        float limiteX = cam.orthographicSize * cam.aspect;

        // Instanciamos el prefab
        GameObject meteo = Instantiate(meteoPrefab, Vector3.zero, Quaternion.identity);

        // Obtenemos la mitad del ancho/alto del sprite
        SpriteRenderer sr = meteo.GetComponent<SpriteRenderer>();
        float mitadAncho = sr.bounds.extents.x;
        float mitadAlto = sr.bounds.extents.y;

        // Posici�n X aleatoria dentro de los m�rgenes
        float enemyOrigenHorizontal = Random.Range(-limiteX + mitadAncho, limiteX - mitadAncho);

        // Posici�n Y fuera de la pantalla (arriba)
        float spawnY = cam.orthographicSize + mitadAlto + 1f;

        meteo.transform.position = new Vector3(enemyOrigenHorizontal, spawnY, 0f);
    }

    IEnumerator SpawnMeteoro()
    {
        while (true)
        {
            CreateEnemy();
            yield return new WaitForSeconds(0.3f);
        }
    }
}
