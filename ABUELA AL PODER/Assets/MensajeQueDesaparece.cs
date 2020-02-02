using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MensajeQueDesaparece : MonoBehaviour
{

    void Start()
    {
        Invoke("Desaparecer", 3f);
    }

    void Desaparecer()
    {
        Destroy(gameObject);
    }
}
