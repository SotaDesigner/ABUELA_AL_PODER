using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IrAlMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("IrMenu", 14f);
    }
    void IrMenu()
    {
        SceneManager.LoadScene(0);
    }

}
