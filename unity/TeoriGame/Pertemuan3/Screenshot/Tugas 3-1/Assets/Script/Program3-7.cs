using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput37 : MonoBehaviour
{
    string myText1, myText2;
    public KeyCode myKey;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            myText1 = "Key Pressed tombol A";
        }

        if (Input.GetKey(KeyCode.B))
        {
            myText1 = "Key Pressed tombol B";
        }

        if (Input.GetKeyUp(myKey))
        {
            myText1 = "Tombol pilihan user";
        }

        if (Input.anyKey)
        {
            myText2 = "Ada tombol yang dipencet terus";
        }
        else
        {
            myText2 = " ";
        }

        if (Input.GetAxis("Fire1") > 0)
        {
            myText1 = "KeyUp: Left Ctrl/Left Mouse";
        }
    }

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(70, 70, 200, 200));
        GUILayout.Label(myText1);
        GUILayout.Label(myText2);
        GUILayout.EndArea();
    }
}
