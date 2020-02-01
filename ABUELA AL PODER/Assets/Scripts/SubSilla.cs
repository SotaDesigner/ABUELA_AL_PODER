using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubSilla : MonoBehaviour
{
    public bool subidoEnSilla = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && GameObject.Find("Silla").GetComponent<Silla>().sillaArreglada)
        {
            subidoEnSilla = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            subidoEnSilla = false;
        }
    }
}
