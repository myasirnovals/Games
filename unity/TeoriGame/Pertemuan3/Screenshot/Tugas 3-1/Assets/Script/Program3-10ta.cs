using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidInput : MonoBehaviour
{
    Vector3 tempaccel;
    Vector2 startpos, currpos;
    string myText1, myText2, myText3, myText4;
    int tempTouch;

    void Start()
    {
        tempTouch = 0;
    }

    void Update()
    {
        #if UNITY_EDITOR
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical"); 
        
        tempaccel = new Vector3(moveX, moveY, 0);
        #else
        tempaccel = Input.acceleration;
        #endif

        bool isTouching = Input.touchCount > 0;
        bool isClicking = Input.GetMouseButton(0);

        if (isTouching || isClicking)
        {
            tempTouch++;

            if (isClicking)
            {
                currpos = Input.mousePosition;
                if (Input.GetMouseButtonDown(0)) startpos = Input.mousePosition;
            }

            foreach (Touch t in Input.touches)
            {
                if (t.phase == TouchPhase.Began) startpos = t.position;
                if (t.phase == TouchPhase.Moved) currpos = t.position;
            }
        }

        myText1 = "Total touch : " + tempTouch.ToString();
        myText2 = "Acceleration : " + tempaccel.ToString(); 
        myText3 = "Start Pos : " + startpos.ToString();
        myText4 = "Current Pos : " + currpos.ToString();
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 300, 20), myText1);
        GUI.Label(new Rect(10, 30, 300, 20), myText2);
        GUI.Label(new Rect(10, 50, 300, 20), myText3);
        GUI.Label(new Rect(10, 70, 300, 20), myText4);
    }
}