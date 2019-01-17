using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_AudioController : MonoBehaviour
{
    public AudioClip AmbientMusic;
    private AudioSource _audio;
    // Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();
        _audio.clip = AmbientMusic;
        _audio.Play();
        _audio.loop = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
