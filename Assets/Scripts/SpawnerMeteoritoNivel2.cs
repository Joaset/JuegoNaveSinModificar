using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMeteoritoNivel2 : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab; // Asignar el prefab en el Inspector

    void Start()
    {
        StartCoroutine(SpawnEnemigos());
    }
    public void CreateEnemy()
    {
        Camera cam = Camera.main;
        float limiteY = cam.orthographicSize;

        // Instanciamos primero para poder calcular el tama�o real del sprite
        GameObject enemy = Instantiate(enemyPrefab, Vector3.zero, Quaternion.identity);

        // Obtenemos la mitad del alto del sprite
        SpriteRenderer sr = enemy.GetComponent<SpriteRenderer>();
        float mitadAlto = sr.bounds.extents.y;

        // Calculamos una posici�n Y v�lida
        float enemyOrigenVertical = Random.Range(-limiteY + mitadAlto, limiteY - mitadAlto);

        // Colocamos el enemigo en X fijo (fuera de la pantalla) y en Y calculado
        float spawnX = cam.orthographicSize * cam.aspect + 1f; // un poquito fuera a la derecha
        enemy.transform.position = new Vector3(spawnX, enemyOrigenVertical, 0f);
    }

    IEnumerator SpawnEnemigos()
    {
        while (true) // bucle infinito como setInterval
        {
            CreateEnemy();
            yield return new WaitForSeconds(1f);
        }
    }
}
