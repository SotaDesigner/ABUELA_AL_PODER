using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuego : MonoBehaviour
{
    public float vida = 0.3f;
    AudioSource _mAs;
    void Start()
    {
        _mAs = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Agua") && vida > 0)
        {
            vida -= 0.1f;
            transform.localScale = new Vector3(vida, vida, vida);
            _mAs.volume -= 0.5f;
        }
    }
}
