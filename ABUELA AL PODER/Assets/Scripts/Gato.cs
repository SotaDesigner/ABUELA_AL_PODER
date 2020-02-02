using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gato : MonoBehaviour
{
    public Fuego fuego;
    SpriteRenderer _mSp;
    Animator _mA;
    public GameObject textoAdios;
    public float vida;

    private void Start()
    {
        _mA = GetComponent<Animator>();
        _mSp = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        vida = fuego.vida;
        if(vida < 0.2f)
        {
            textoAdios.SetActive(true);
            _mA.SetBool("Salbado", true);
        }
        if(vida <= 0.1)
        {
            Invoke("CambioEscena", 2f);
        }
    }
    void CambioEscena()
    {
        SceneManager.LoadScene(5);
    }
}

