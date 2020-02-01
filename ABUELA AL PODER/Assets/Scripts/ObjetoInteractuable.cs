using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoInteractuable : MonoBehaviour
{
    bool _playerCerca = false;
    public Sprite cambio;
    public SpriteRenderer objetoEscondido;
    private SpriteRenderer _sr;
    public Collider2D objetoEscondidoCol;

    // Start is called before the first frame update
    void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_playerCerca && Input.GetKeyDown(KeyCode.Q))
        {
            Interactuar();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            _playerCerca = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            _playerCerca = false;
        }
    }
    void Interactuar()
    {
        _sr.sprite = cambio;
        objetoEscondido.enabled = true;
        objetoEscondidoCol.enabled = true;
        //_go.SpriteRenderer = enabled;
        //_go.collider = isActiveAndEnabled;
    }
}
