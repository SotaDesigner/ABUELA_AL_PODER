using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rb;
    float _ejeX;
    public Transform silla;
    
    //Velocidad de movimiento del players
    public float velocidadMovimiento = 5;
    
    //Rotar al personaje si mira a la derecha o a la izquierda
    bool miraDerecha = true;

    bool puedoUsarBombilla = false;

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

        GestionAnimaciones();
        
        if(puedoUsarBombilla)
        {
            GameController.copia.NextLevel1();
        }
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if(GameObject.Find("Bombilla").GetComponent<Objeto>().manoOcupada && collision.CompareTag("Lampara"))
        //{
        //  puedoUsarBombilla = true;
        //}
        if (collision.CompareTag("SubirseSilla") && Input.GetKeyDown(KeyCode.W))
        {
            transform.position = Vector2.MoveTowards(_rb.position, silla.position, Time.deltaTime);
        }
    }
}
