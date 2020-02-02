using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuego : MonoBehaviour
{
    float vida = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Agua"))
        {
            Debug.Log("colision");
            vida -= 0.5f;
            transform.localScale = new Vector3(vida, vida, vida);
        }
    }
    private void Update()
    {
        if(vida == 0)
        {
            Destroy(gameObject);
        }
    }
}
