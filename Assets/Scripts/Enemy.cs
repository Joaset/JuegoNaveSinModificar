using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Vector3 speed;

    void Start()
    {
        speed = new Vector3(2f, 0f, 0f); // velocidad en unidades/segundo
    }
    void Update()
    {
        transform.position -= speed * Time.deltaTime;
        if (transform.position.x <= (-10))
        {
            Destroy(gameObject);
        }
    }
}
