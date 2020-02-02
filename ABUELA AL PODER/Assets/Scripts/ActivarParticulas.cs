using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarParticulas : MonoBehaviour
{
    public GameObject sistemaParticulas;
    bool tocandoPlayer;
    public Collider2D colApagaFuego;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && tocandoPlayer)
        {
            sistemaParticulas.SetActive(true);
            colApagaFuego.enabled = true;
            Invoke("ApagarSistemaDeParticulas", 2f);
        }
    }
    void ApagarSistemaDeParticulas()
    {
        colApagaFuego.enabled = false;
        sistemaParticulas.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tocandoPlayer = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tocandoPlayer = false;
        }
    }
}
