using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silla : MonoBehaviour
{
    public bool _playerCerca = false;
    public bool sillaArreglada = false;

    Rigidbody2D _rb;
    private SpriteRenderer _sillaRota;
    public Sprite sillaReparadaSpr;

    public Collider2D colSillaRota;
    public Collider2D colSillaReparada;
    public Collider2D colSillaReparadaTigre;
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
        if(GameObject.Find("SupSilla").GetComponent<SubSilla>().subidoEnSilla)
        {
            _rb.isKinematic = true;
        }
        else if(!GameObject.Find("SupSilla").GetComponent<SubSilla>().subidoEnSilla)
        {
            _rb.isKinematic = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
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
        sillaArreglada = true;
        colSillaRota.enabled = false;
        colSillaReparada.enabled = true;
        colSillaReparadaTigre.enabled = true;

        _rb.gravityScale = 5;
    }
    
}
