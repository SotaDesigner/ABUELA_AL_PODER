using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LLave : MonoBehaviour
{
    Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Puerta1"))
        {
            GameController.copia.NextLevel2();
        }
        if (collision.CompareTag("Puerta2"))
        {
            GameController.copia.NextLevel3();
        }
    }
}
