using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    int vidas = 2;

    //Sprite que se pone en pantalla cuando recibo daño
    public SpriteRenderer dañado;

    public static GameController copia;

    // Start is called before the first frame update
    void Start()
    {
        if(copia==null)
        {
            copia = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestaVida()
    {
        if (vidas > 0) vidas--;
        Debug.Log("Has perdido una vida");
        if(vidas<1)
        {
            Debug.Log("Anda que morir en este juego... Verguenza me daria :D");
            SceneManager.LoadScene(0);
        }
        GameObject.Find("Bateria").GetComponent<Bateria>().colliderBateria.enabled = false;
    }
}
