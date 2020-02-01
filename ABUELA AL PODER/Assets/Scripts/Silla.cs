﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silla : MonoBehaviour
{
    bool _playerCerca = false;

    Rigidbody2D _rb;
    private SpriteRenderer _sillaRota;
    public Sprite sillaReparadaSpr;

    public Collider2D colSillaRota;
    public Collider2D colSillaReparada;
    public Transform player;
    public Transform arriba;

    //float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        _sillaRota = GetComponent<SpriteRenderer>();
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_playerCerca && Input.GetKeyDown(KeyCode.Q))
        {
            Reparar();
        }
        if(GameObject.Find("Player").GetComponent<PlayerController>().sillaArreglada)
        {
            _rb.isKinematic = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            _playerCerca = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _playerCerca = false;
        }
    }
    void Reparar()
    {
        _sillaRota.sprite = sillaReparadaSpr;

        colSillaRota.enabled = false;
        colSillaReparada.enabled = true;

        _rb.gravityScale = 5;
    }
    
}