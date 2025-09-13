using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovRedEnemy : MonoBehaviour
{
     [SerializeField] private float speed;
    Transform transform;
    void Start()
    {
        speed = 10f; // velocidad en unidades/segundo
    }
    void Update()
    {
        transform.position.x -= speed * Time.deltaTime;
        if (transform.position.y <= (-6))
        {
            Destroy(gameObject);
        }
    }
}
