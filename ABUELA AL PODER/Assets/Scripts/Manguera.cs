using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manguera : MonoBehaviour
{

    //public bool tocandoPlayer = false;
    //public GameObject mangueraLow;
    //public GameObject mangueraHigh;

    //public GameObject _particulasSueloLow;

    //private void Start()
    //{
    //    //_particulasSuelo = GetComponentInChildren<ParticleSystem>();

    //}
    //private void Update()
    //{
    //    if (mangueraLow.GetComponent<Objeto>().emiteParticulasLow)
    //    {
    //        Debug.Log("!");

    //        _particulasSueloLow.SetActive(true);
    //    }
    //    if (mangueraLow.GetComponent<Objeto>().emiteParticulas)
    //    {
    //        Debug.Log("pp");
    //        mangueraHigh.SetActive(true);
    //        mangueraLow.SetActive(false);
    //    }
    //}
    //private void OnTriggerStay2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Player"))
    //    {
    //        tocandoPlayer = true;
    //    }
    //}
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Player"))
    //    {
    //        tocandoPlayer = false;
    //    }
    //}

    public GameObject MangueraHigh;
    bool tocandoPlayer = false;
    public GameObject sistemaParticulas;
    public GameObject panelDeTextoGato;
    public GameObject panelDeTextoGato2;
    public GameObject llave;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (tocandoPlayer && Input.GetKey(KeyCode.Q) && !llave.GetComponent<Objeto>().bombillaCogida)
        {
            sistemaParticulas.SetActive(true);
            panelDeTextoGato.SetActive(true);
            Invoke("ApagarSistemaDeParticulas", 4f);
        }
        if(tocandoPlayer && Input.GetKey(KeyCode.Q) && llave.GetComponent<Objeto>().bombillaCogida)
        {
            MangueraHigh.SetActive(true);
            Destroy(gameObject);
        }
    }
    void ApagarSistemaDeParticulas()
    {
        sistemaParticulas.SetActive(false);
        panelDeTextoGato.SetActive(false);
        Invoke("Texto", 2f);
    }
    void Texto()
    {
        panelDeTextoGato2.SetActive(true);
        Invoke("DesactivarTexto", 2f);
    }
    void DesactivarTexto()
    {
        panelDeTextoGato2.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
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
