using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private SpriteRenderer spriter;
    public Color newColor;

    void Start()
    {
        spriter = GetComponent<SpriteRenderer>();
        spriter.color = newColor;
    }

}
