using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetoInteractuable : MonoBehaviour
{
    bool _playerCerca = false;
    public Sprite cambio;
    public SpriteRenderer objetoEscondido;
    private SpriteRenderer _sr;
    public Collider2D objetoEscondidoCol;
    public GameObject textoActibable;
    public GameObject textoGato;
    Collider2D _mC;
    AudioSource _mAs;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        _mAs = GetComponent<AudioSource>();
        _sr = GetComponent<SpriteRenderer>();
        _mC = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_playerCerca && Input.GetKeyDown(KeyCode.Q))
        {
            Interactuar();
            textoGato.SetActive(true);
            Invoke("DesactivarTexto", 2f);
        }
    }
    void DesactivarTexto()
    {
        textoGato.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            _playerCerca = true;
            textoActibable.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            _playerCerca = false;
            textoActibable.SetActive(false);
        }
    }
    void Interactuar()
    {
        _mAs.clip = clip;
        _mAs.Play();
        _sr.sprite = cambio;
        objetoEscondido.enabled = true;
        objetoEscondidoCol.enabled = true;
        _mC.enabled = false;
    }
}
