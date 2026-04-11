using UnityEngine;

public class AndroidInput310 : MonoBehaviour
{
    Vector3 tempaccel;
    Vector2 startpos, currpos;
    string myText1, myText2, myText3, myText4;
    int tempTouch;

    // Start is called before the first frame update
    void Start()
    {
        tempTouch = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tempaccel = Input.acceleration;

        if (Input.touchCount > 0)
        {
            tempTouch++;

            foreach (Touch t in Input.touches)
            {
                switch (t.phase)
                {
                    case TouchPhase.Began:
                        startpos = t.position;
                        break;

                    case TouchPhase.Moved:
                        currpos = t.position;
                        break;
                }
            }
        }

        myText1 = "Total touch : " + tempTouch.ToString();
        myText2 = "Acceleration : " + tempaccel.ToString();
        myText3 = "Start Pos : " + startpos.ToString();
        myText4 = "Current Pos : " + currpos.ToString();
    }
}
