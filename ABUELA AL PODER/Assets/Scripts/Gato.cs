using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if(vida < 0.2)
        {
            textoAdios.SetActive(true);
            _mA.SetBool("Salbado", true);
        }
    }
}

