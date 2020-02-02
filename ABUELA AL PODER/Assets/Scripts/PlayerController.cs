using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rb;
    float _ejeX;
    public Transform silla;
    
    //Velocidad de movimiento del players
    public float velocidadMovimiento = 5;
    
    //Rotar al personaje si mira a la derecha o a la izquierda
    bool miraDerecha = true;
    bool _puedeSubirse = false;
    Animator _anim;

    bool puedoUsarBombilla = false;

    

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Me registra las teclas para el movimiento
        _ejeX = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(_ejeX * velocidadMovimiento, _rb.velocity.y);

        GestionAnimaciones();
        
        if(puedoUsarBombilla)
        {
            GameController.copia.NextLevel1();
        }
        if(_puedeSubirse && Input.GetKeyDown(KeyCode.W))
        {
            transform.position = silla.position;
        }
            PoderSubirse();
    }
    
    void GestionAnimaciones()
    {
        _anim.SetFloat("Velocidad", Mathf.Abs(_rb.velocity.x));

        if (_ejeX<0 && miraDerecha)
        {
            transform.Rotate(0, 180, 0);
            miraDerecha = false;

        } else if(_ejeX>0 && !miraDerecha)
        {
            transform.Rotate(0, 180, 0);
            miraDerecha = true;
        }
    }

    void PoderSubirse()
    {
        if (GameObject.Find("Silla").GetComponent<Silla>()._playerCerca && GameObject.Find("Silla").GetComponent<Silla>().sillaArreglada)
        {
            _puedeSubirse = true;
        }
        else
        {
            _puedeSubirse = false;
        }
    }
}
