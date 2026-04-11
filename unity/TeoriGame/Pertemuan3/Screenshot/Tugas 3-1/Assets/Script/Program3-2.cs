using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType32 : MonoBehaviour
{
    public int bulat;
    public float desimal;
    public char karakter;
    public string text;

    public enum Vote { Bagus, Lumayan, Garing }
    public Vote comment;

    string myText;
    public Vector2 koordinat2D;
    public Vector3 koordinat3D;

    void Start()
    {
        if (comment == Vote.Bagus)
        {
            myText = "Bagus banget euy";
        }
        else
        {
            myText = "ya gitu deh";
        }
    }

    void Update()
    {
    }

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10, 10, 200, 200));
        GUILayout.Label("Bilangan Bulat : " + bulat.ToString());
        GUILayout.Label("Bilangan real : " + desimal.ToString());
        GUILayout.Label("Nilai karakter : " + karakter.ToString());
        GUILayout.Label("Nilai string text : " + text.ToString());
        GUILayout.Label("Nilai Komentar : " + myText.ToString());
        GUILayout.Label("2D : " + koordinat2D.ToString());
        GUILayout.Label("3D : " + koordinat3D.ToString());
        GUILayout.EndArea();
    }
}
