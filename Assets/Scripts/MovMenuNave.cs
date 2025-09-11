using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovMenuNave : MonoBehaviour
{
    [SerializeField] private Vector3 speed;

    void Start()
    {
        speed = new Vector3(1f, 0f, 0f); // velocidad en unidades/segundo
    }
    void Update()
    {
      transform.position += speed*Time.deltaTime;
        if (transform.position.x >= (10.92))
        {
            transform.position = new Vector3(-9.39f, transform.position.y, transform.position.z);
        }
    }
}
