using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput39 : MonoBehaviour
{
    string myText, myText2, myText3, myText4;
    int number;
    float delta;

    void Start()
    {
        number = 0;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            myText = "Mouse tombol kiri";
        }

        if (Input.GetMouseButton(1))
        {
            myText = "Mouse tombol kanan";
        }

        myText2 = "Position: " + Input.mousePosition.ToString();
    }
}
