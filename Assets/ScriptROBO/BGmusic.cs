using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGmusic : MonoBehaviour
{
    public AudioClip Music;

    // Start is called before the first frame update
    void Start()
    {
        SoundMenager.instance.PlayMusic(Music);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
