using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarEscena : MonoBehaviour
{

    void Start()
    {
        Invoke("CargarEscenaDos", 8f);
    }

    void CargarEscenaDos()
    {
        SceneManager.LoadScene(2);
    }
}
