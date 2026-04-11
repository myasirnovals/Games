using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string myText;

    void Start()
    {
    }

    void Update()
    {
        Debug.Log(myText);
    }

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10, 10, 200, 200));
        GUILayout.Label(myText);
        GUILayout.EndArea();
    }
}