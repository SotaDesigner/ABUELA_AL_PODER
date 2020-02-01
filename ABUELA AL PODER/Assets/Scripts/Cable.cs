using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : MonoBehaviour
{
    bool cableEmpalmado = false;
    public Collider2D colliderCable;
    private SpriteRenderer cable;
    public Sprite cableNoEmpalmado;
    public Sprite cableEmpalmadoSpr;

    private void Update()
    {
        //if (cableEmpalmado)
        {
            //    cable.sprite = cableEmpalmadoSpr;
        }
        //else if (!cableEmpalmado)
        {
            //  cable.sprite = cableNoEmpalmado;
        }
    }
    private void OnMouseDown()
    {
        //if (GameObject.Find("Bateria").GetComponent<Bateria>().bateriaConectada)
        {
            //  GameController.copia.RestaVida();
        }
        //else if(!GameObject.Find("Bateria").GetComponent<Bateria>().bateriaConectada)
        {
            //  Debug.Log("Cable empalmado");
            //cableEmpalmado = true;
            //colliderCable.enabled = false;
        }

    }
}
