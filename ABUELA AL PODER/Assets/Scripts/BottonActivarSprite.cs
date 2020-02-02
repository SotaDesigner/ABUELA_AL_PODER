using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottonActivarSprite : MonoBehaviour
{
    public GameObject sprite;
    AudioSource _mAs;
    public AudioClip sonidoBoton;

    private void Start()
    {
        _mAs = GetComponent<AudioSource>();
    }
    private void OnMouseOver()
    {
        sprite.SetActive(true);
    }
    private void OnMouseExit()
    {
        sprite.SetActive(false);
    }
    public void CargarPrimeraEscena()
    {
        _mAs.clip = sonidoBoton;
        _mAs.Play();
        Invoke("PrimeraEscena", 1f);
    }
    void PrimeraEscena()
    {
        SceneManager.LoadScene(1);
    }
    public void Salir()
    {
        float numeroPich = 0.7f;
        _mAs.pitch = numeroPich;
        _mAs.clip = sonidoBoton;
        _mAs.Play();
        Invoke("EjecutarSalir", 1f);
    }
    void EjecutarSalir()
    {
        Application.Quit();
    }
}
