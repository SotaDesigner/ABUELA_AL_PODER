using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour
{
    bool _playerCerca = false;
    bool _manoOcupada = false;
    bool _posibleInteractuar = false;

    Transform _player;
    Transform _mano;

    // Start is called before the first frame update
    void Start()
    {
        _mano = GameObject.Find("ManoDerecha").transform;
        _player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(_playerCerca && !_manoOcupada && Input.GetKeyDown(KeyCode.E))
        {
            CogerObjeto();
        }
        else if(_manoOcupada&&Input.GetKeyDown(KeyCode.E))
        {
            SoltarObjeto();
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
        if(collision.transform.CompareTag("Player"))
        {
            _playerCerca = false;
        }
    }
    void CogerObjeto()
    {
        transform.parent = _mano;

        transform.localPosition = Vector3.zero;
        transform.rotation = _player.rotation;

        _manoOcupada = true;
    }
    void SoltarObjeto()
    {
        transform.parent = null;

        _manoOcupada = false;
    }
}
