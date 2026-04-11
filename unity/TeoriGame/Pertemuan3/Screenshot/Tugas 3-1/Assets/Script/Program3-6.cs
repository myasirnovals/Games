using UnityEngine;

public class InputExample36 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up * 1f);
            Debug.Log("Karakter melompat");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Game di-pause / menu dibuka");
        }
    }
}
