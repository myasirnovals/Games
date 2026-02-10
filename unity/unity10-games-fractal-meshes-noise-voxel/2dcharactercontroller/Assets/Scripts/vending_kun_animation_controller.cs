using UnityEngine;

public class vending_kun_animation_controller : MonoBehaviour
{
    public Animator vendingkunAnims;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            vendingkunAnims.SetBool("run", true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            vendingkunAnims.SetBool("run", false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            vendingkunAnims.SetTrigger("attack");
        }
    }
}
