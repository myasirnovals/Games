using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayClass33 : MonoBehaviour
{
    public int[] numbers;
    public string[] texts;

    [System.Serializable]
    public class Collection
    {
        public int ID;
        public string anyValue;
    }

    string myText1, myText2, myText3;
    public Collection[] colletions;

    void Start()
    {
        myText1 = " ";
        for (int c = 0; c < numbers.Length; c++)
        {
            myText1 += numbers[c].ToString() + ' ';
        }

        myText2 = " ";
        for (int i = 0; i < texts.Length; i++)
        {
            myText2 += texts[i] + ' ';
        }

        myText3 = " ";
        for (int i = 0; i < colletions.Length; i++)
        {
            myText3 += colletions[i].ID.ToString() + ":" + colletions[i].anyValue + " ";
        }
    }

    void Update()
    {
    }

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(70, 70, 400, 200));
        GUILayout.Label("Array Integer : " + myText1);
        GUILayout.Label("Array String : " + myText2);
        GUILayout.Label("Array Object : " + myText3);
        GUILayout.EndArea();
    }
}
