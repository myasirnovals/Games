using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tembak : MonoBehaviour
{
    public AudioSource tembakAudio;

    int countTembak = 0;

    // start is called before the first frame update
    void Start()
    {
        countTembak = PlayerPrefs.GetInt("power");
        Debug.Log(countTembak);
    }

    // update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Fire1") != 0)
        {
            Debug.Log("Tembak! ");
            Debug.Log(countTembak);
            tembakAudio.Play();
            countTembak++;
            PlayerPrefs.SetInt("power", countTembak);
        }
    }
}
