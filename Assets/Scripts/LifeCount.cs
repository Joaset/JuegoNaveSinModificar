using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LifeCount : MonoBehaviour
{
    private TextMeshProUGUI textMesh;

    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        textMesh.text = "Vida: " + GameManager.Instance.vidaMaxima.ToString() + "%";
    }
}
