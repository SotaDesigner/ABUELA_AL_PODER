using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rb;
    float _ejeX;

    //Velocidad de movimiento del players
    public float velocidadMovimiento = 5;
    
    //Rotar al personaje si mira a la derecha o a la izquierda
    bool miraDerecha = true;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Me registra las teclas para el movimiento
        _ejeX = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(_ejeX * velocidadMovimiento, _rb.velocity.y);
    }
    
    void GestionAnimaciones()
    {

        if(_ejeX<0 && miraDerecha)
        {
            transform.Rotate(0, 180, 0);
            miraDerecha = false;

        } else if(_ejeX>0 && !miraDerecha)
        {
            transform.Rotate(0, 180, 0);
            miraDerecha = true;
        }
    }
}
