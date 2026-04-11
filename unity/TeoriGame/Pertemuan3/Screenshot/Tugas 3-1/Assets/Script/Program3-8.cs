using UnityEngine;

public class MouseInputExample38 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Tombol kiri mouse ditekan.");
        }

        if (Input.GetMouseButton(1))
        {
            Debug.Log("Tombol kanan mouse ditekan.");
        }

        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Tombol tengah mouse ditekan.");
        }

        Vector3 mousePosition = Input.mousePosition;
        Debug.Log("Posisi mouse: " + mousePosition);

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        Debug.Log("Input mouse X: " + mouseX + ", Input mouse Y: " + mouseY);
    }
}
