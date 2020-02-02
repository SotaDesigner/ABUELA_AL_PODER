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

    Transform _player;
    Transform _mano;
    AudioSource _mAs;
    public AudioClip clip;
    public AudioClip colocarClip;
    // Start is called before the first frame update
    void Start()
    {
        _mAs = GetComponent<AudioSource>();
        _mano = GameObject.Find("ManoDerecha").transform;
        _player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
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
            _mAs.clip = colocarClip;
            _mAs.Play();
            Invoke("CargarEscenaSiguiente", 1f);
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
    void CargarEscenaSiguiente()
    {
        SceneManager.LoadScene(3);
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
        _mAs.clip = clip;
        _mAs.Play();
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
