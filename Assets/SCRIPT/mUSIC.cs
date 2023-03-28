using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mUSIC : MonoBehaviour
{
    public GameObject camera;
    private AudioSource _audioSource;

    //public GameObject ball;
    public void Start()
    {
        _audioSource = camera.GetComponent<AudioSource>();
    }

    public void MusicVolume(float v)
    {
        //camera.GetComponent<AudioSource>().volume = v;
       _audioSource.volume = v;
    }
}
