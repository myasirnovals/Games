using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Numerics;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject claw = null;
    public Animator animatorControllerGun = null;

    private bool isShooting = false;
    private LayerMask currentMask;

    public bool IsShooting
    {
        get
        {
            return isShooting;
        }
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && !isShooting)
        {
            LaunchClaw();
        }
    }

    private void LaunchClaw()
    {
        isShooting = true;

        if (animatorControllerGun != null)
        {
            animatorControllerGun.speed = 0f;

            RaycastHit hit;
            Vector3 down = transform.TransformDirection(Vector3.down);

            if(Physics.Raycast(transform.position, down, out hit, 100f))
            {
                // TODO: Activate CLaw when done and define it with a target.
            }
        }
    }
}
