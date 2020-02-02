using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manguera : MonoBehaviour
{

    public bool tocandoPlayer = false;
    public GameObject mangueraLow;
    public GameObject mangueraHigh;

    public GameObject _particulasSueloLow;

    private void Start()
    {
        //_particulasSuelo = GetComponentInChildren<ParticleSystem>();
        
    }
    private void Update()
    {
        if (mangueraLow.GetComponent<Objeto>().emiteParticulasLow)
        {
            Debug.Log("!");
            
            _particulasSueloLow.SetActive(true);
        }
        if (mangueraLow.GetComponent<Objeto>().emiteParticulas)
        {
            Debug.Log("pp");
            mangueraHigh.SetActive(true);
            mangueraLow.SetActive(false);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
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
