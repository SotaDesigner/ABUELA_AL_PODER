using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silla : MonoBehaviour
{
    public bool _playerCerca = false;
    public bool sillaArreglada = false;

    Rigidbody2D _rb;
    AudioSource _mAs;
    public AudioClip clip;

    private SpriteRenderer _sillaRota;
    public Sprite sillaReparadaSpr;

    public GameObject textoAyudaReparar;
    public GameObject textoAyudaSubir;

    public Collider2D colSillaRota;
    public Collider2D colSillaReparada;
    public Collider2D colSillaReparadaTigre;
    public Transform player;
    public Transform arriba;


    //float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        _mAs = GetComponent<AudioSource>();
        _sillaRota = GetComponent<SpriteRenderer>();
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_playerCerca && Input.GetKeyDown(KeyCode.Q))
        {
            SonidoYreparar();
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
        if(collision.CompareTag("Player") && !sillaArreglada)
        {
            textoAyudaReparar.SetActive(true);
        }
        if (collision.CompareTag("Player") && sillaArreglada)
        {
            textoAyudaSubir.SetActive(true);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _playerCerca = false;
            textoAyudaReparar.SetActive(false);
        }
        if (collision.CompareTag("Player") && sillaArreglada)
        {
            textoAyudaSubir.SetActive(false);
        }

    }

    void SonidoYreparar()
    {
        _mAs.clip = clip;
        _mAs.Play();
        Invoke("Reparar", 1f);
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
