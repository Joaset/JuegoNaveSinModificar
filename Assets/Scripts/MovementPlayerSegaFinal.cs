using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayerSegaFinal : MonoBehaviour
{
    [SerializeField] private float velocidad = 5f;

    private float limiteX;
    private float limiteY;
    private float mitadAncho;
    private float mitadAlto;
    private Animator animator;

    void Start()
    {
        // Calcular el tama�o de la nave en unidades del mundo
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        mitadAncho = sr.bounds.extents.x; // la mitad del ancho del sprite
        mitadAlto = sr.bounds.extents.y;  // la mitad del alto del sprite
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Movimiento con teclas
        float movX = 0f;
        float movY = 0f;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            movX = -1f;
            animator.SetBool("SegaUp", true);
        }
        else
        {
            animator.SetBool("SegaUp", false);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            movX = 1f;
            animator.SetBool("SegaDown", true);
        }
        else
        {
            animator.SetBool("SegaDown", false);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            movY = 1f;
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            movY = -1f;

        Vector3 movimiento = new Vector3(movX, movY, 0f).normalized;
        transform.position += movimiento * velocidad * Time.deltaTime;

        // Calcular los l�mites de la c�mara
        Camera cam = Camera.main;
        limiteY = cam.orthographicSize;
        limiteX = limiteY * cam.aspect;

        // Ajustar l�mites restando el tama�o de la nave
        float x = Mathf.Clamp(transform.position.x, -limiteX + mitadAncho, limiteX - mitadAncho);
        float y = Mathf.Clamp(transform.position.y, -limiteY + mitadAlto, limiteY - mitadAlto);
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
