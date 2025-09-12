using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeItem : MonoBehaviour
{
    [SerializeField] private float velocidad = 2f;
    private Rigidbody2D rb;
    private Camera cam;
    private float limiteX, limiteY;
    private float mitadAncho, mitadAlto;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;

        // Tama�o del sprite
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        mitadAncho = sr.bounds.extents.x;
        mitadAlto = sr.bounds.extents.y;

        // Velocidad inicial en diagonal
        rb.velocity = new Vector2(velocidad, velocidad);
    }

    void Update()
    {
        // Calcular l�mites de la c�mara en este frame
        limiteY = cam.orthographicSize;
        limiteX = limiteY * cam.aspect;

        Vector3 pos = transform.position;

        // Rebote horizontal
        if (pos.x + mitadAncho >= limiteX)
        {
            pos.x = limiteX - mitadAncho; // corrige la posici�n
            rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
        }
        else if (pos.x - mitadAncho <= -limiteX)
        {
            pos.x = -limiteX + mitadAncho;
            rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
        }

        // Rebote vertical
        if (pos.y + mitadAlto >= limiteY)
        {
            pos.y = limiteY - mitadAlto;
            rb.velocity = new Vector2(rb.velocity.x, -rb.velocity.y);
        }
        else if (pos.y - mitadAlto <= -limiteY)
        {
            pos.y = -limiteY + mitadAlto;
            rb.velocity = new Vector2(rb.velocity.x, -rb.velocity.y);
        }

        transform.position = pos; // aplicar la correcci�n
    }
}
