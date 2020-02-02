using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarParticulas : MonoBehaviour
{
    public GameObject sistemaParticulas;
    bool tocandoPlayer;
    public Collider2D colApagaFuego;
    AudioSource _mAs;
    public AudioClip clip;

    private void Start()
    {
        _mAs = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && tocandoPlayer)
        {
            _mAs.clip = clip;
            _mAs.Play();
            Invoke("ActivarParticulasUno", 1f);
        }
    }
    void ActivarParticulasUno()
    {
        sistemaParticulas.SetActive(true);
        colApagaFuego.enabled = true;
        Invoke("ApagarSistemaDeParticulas", 2.5f);
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
