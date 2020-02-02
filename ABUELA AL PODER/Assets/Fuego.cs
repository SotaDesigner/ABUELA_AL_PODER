using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuego : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Agua"))
        {
            transform.localScale = new Vector3(transform.localScale.x - 0.5f, transform.localScale.y - 0.5f, transform.localScale.z);
        }
    }
    private void Update()
    {
        if(transform.localScale == new Vector3(0,0,0))
        {
            Destroy(gameObject);
        }
    }
}
