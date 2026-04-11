using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class PlayerControls : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 offset;

    private float maxLeft;
    private float maxRight;
    private float maxDown;
    private float maxUp;

    [SerializeField] private InputActionReference moveActionToUse;
    [SerializeField] private float speed;

    void Start()
    {
        mainCam = Camera.main;
        StartCoroutine(SetBoundaries());
    }

    private IEnumerator SetBoundaries()
    {
        yield return new WaitForSeconds(0.4f);
        maxLeft = mainCam.ViewportToWorldPoint(new Vector2(0.15f, 0)).x;
        maxRight = mainCam.ViewportToWorldPoint(new Vector2(0.85f, 0)).x;
        maxDown = mainCam.ViewportToWorldPoint(new Vector2(0, 0.05f)).y;
        maxUp = mainCam.ViewportToWorldPoint(new Vector2(0, 0.6f)).y;
    }

    void Update()
    {
        Vector2 moveDirection = moveActionToUse.action.ReadValue<Vector2>();
        transform.Translate(moveDirection * speed * Time.deltaTime);

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, maxLeft, maxRight),
            Mathf.Clamp(transform.position.y, maxDown, maxUp),
            0
        );
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