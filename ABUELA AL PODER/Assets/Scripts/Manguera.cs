using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manguera : MonoBehaviour
{

    public bool tocandoPlayer = false;
    public GameObject mangueraLow;
    public GameObject mangueraHigh;

    ParticleSystem _particulasSuelo;
    private void Start()
    {
        _particulasSuelo = GetComponent<ParticleSystem>();
    }
    private void Update()
    {
        if(GameObject.Find("Manguera").GetComponent<Objeto>().emiteParticulasLow)
        {
            _particulasSuelo.Play();
        }
        if (GameObject.Find("Manguera").GetComponent<Objeto>().emiteParticulas)
        {
            mangueraHigh.SetActive(true);
            mangueraLow.SetActive(false);
            _particulasSuelo.Play();
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
