using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour{

    [SerializeField]
    private Transform[] juego;

    [SerializeField]
    private GameObject winText;

    public static bool youWin;

    

    void Start (){
  
        winText.SetActive(false);
        youWin = false;
    }

    void Update (){
         if (juego[0].rotation.z == 0 &&
            juego[1].rotation.z == 0 &&
            juego[2].rotation.z == 0 &&
            juego[3].rotation.z == 0 &&
            juego[4].rotation.z == 0 &&
            juego[5].rotation.z == 0 &&
            juego[6].rotation.z == 0 &&
            juego[7].rotation.z == 0 &&
            juego[8].rotation.z == 0 &&
            juego[9].rotation.z == 0 &&
            juego[10].rotation.z == 0 )
         {
            youWin = true;
            winText.SetActive(true);
         }
    }
}
