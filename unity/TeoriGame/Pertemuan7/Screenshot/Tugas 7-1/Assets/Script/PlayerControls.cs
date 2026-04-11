using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class PlayerControls : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 offset;

    void Start()
    {
        mainCam = Camera.main;
    }

    void Update()
    {
        if (Touch.fingers[0].isActive)
        {
            Touch myTouch = Touch.activeTouches[0];
            Vector3 touchPos = myTouch.screenPosition;
            touchPos = mainCam.ScreenToWorldPoint(touchPos);

            if (myTouch.phase == TouchPhase.Began)
            {
                offset = touchPos - transform.position;
            }

            if (myTouch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(touchPos.x - offset.x, touchPos.y - offset.y, 0);
            }

            if (myTouch.phase == TouchPhase.Stationary)
            {
                transform.position = new Vector3(touchPos.x - offset.x, touchPos.y - offset.y, 0);
            }
        }
    }

    private void OnEnable()
    {
        EnhancedTouchSupport.Enable();
    }

    private void OnDisable()
    {
        EnhancedTouchSupport.Disable();
    }
}