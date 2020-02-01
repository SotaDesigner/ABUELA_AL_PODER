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
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Interacturar();
        }
    }
}
