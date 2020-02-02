using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveInglesa : MonoBehaviour
{
    Objeto scritipObjeto;
    public bool ObjetoCogido;
    void Start()
    {
        scritipObjeto = GetComponent<Objeto>();
    }
    private void Update()
    {
        ObjetoCogido = scritipObjeto.bombillaCogida;
    }
}
