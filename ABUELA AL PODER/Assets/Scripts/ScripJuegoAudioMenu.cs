using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripJuegoAudioMenu : MonoBehaviour
{
    AudioSource _mAs;
    void Start()
    {
        _mAs = GetComponent<AudioSource>();
        InvokeRepeating("CambioPich", 4f, 3f);
    }
    void CambioPich()
    {
        float numeroAleatorio;
        numeroAleatorio = Random.Range(0.5f, 2f);
        _mAs.pitch = numeroAleatorio;
    }
}
