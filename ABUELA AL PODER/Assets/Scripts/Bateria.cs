using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bateria : MonoBehaviour
{
    public Sprite bateriaDesconectada;
    public Sprite bateriaConectadaSpr;
    private SpriteRenderer bateria;
    public bool bateriaConectada = false;
    public Collider2D colliderBateria;

    private void Start()
    {
        //bateria.sprite = bateriaDesconectada;
    }
    private void Update()
    {
        //if(bateriaConectada)
        {
          //  bateria.sprite = bateriaConectadaSpr;
        } //else if(!bateriaConectada)
        {
            //bateria.sprite = bateriaDesconectada;
        }
    }
    //void OnMouseDown()
    //{
        //Debug.Log("Bateria conectada");
        //colliderBateria.enabled = false;
        //bateriaConectada = true;       
    //}
}
