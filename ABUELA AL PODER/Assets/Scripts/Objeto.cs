using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Objeto : MonoBehaviour
{
    bool _playerCerca = false;
    public bool manoOcupada = false;
    public bool bombillaCogida = false;
    public bool emiteParticulasLow = false;
    public bool emiteParticulas = false;
    bool _posibleInteractuar = false;
    public GameObject textoAyuda;
    public LlaveInglesa scriptLlaveI;

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
        bombillaCogida = scriptLlaveI.ObjetoCogido;
        if(_playerCerca && !manoOcupada && Input.GetKeyDown(KeyCode.E))
        {
            CogerObjeto();
        }
        else if(manoOcupada&&Input.GetKeyDown(KeyCode.E))
        {
            SoltarObjeto();
        }
        if(bombillaCogida && GameObject.Find("Lampara").GetComponent<Lampara>().tocandoPlayer && Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(1);
        }
        if (!bombillaCogida && GameObject.Find("MangueraLow").GetComponent<Manguera>().tocandoPlayer && Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Activar manguera");
            emiteParticulasLow = true;

        }
        else if (bombillaCogida && GameObject.Find("MangueraLow").GetComponent<Manguera>().tocandoPlayer && Input.GetKeyDown(KeyCode.Q))
        {
            
            emiteParticulas = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            _playerCerca = true;
            textoAyuda.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            _playerCerca = false;
            textoAyuda.SetActive(false);
        }
    }
    void CogerObjeto()
    {
        transform.parent = _mano;

        transform.localPosition = Vector3.zero;
        transform.rotation = _player.rotation;

        manoOcupada = true;
        bombillaCogida = true;
    }
    void SoltarObjeto()
    {
        transform.parent = null;

        manoOcupada = false;
        bombillaCogida = false;
    }
}
