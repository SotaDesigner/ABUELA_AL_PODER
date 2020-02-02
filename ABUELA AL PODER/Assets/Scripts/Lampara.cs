using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lampara : MonoBehaviour
{
    public bool tocandoPlayer = false;
    public GameObject textoAyuda;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            tocandoPlayer = true;
            textoAyuda.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tocandoPlayer = false;
            textoAyuda.SetActive(false);
        }
    }
}
