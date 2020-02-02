using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    //GameController pierdVida;
    //private void Start()
    //{
    //    pierdVida = GameController.copia.RestaVida();
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            GameController.copia.RestaVida();
        }
    }
}
