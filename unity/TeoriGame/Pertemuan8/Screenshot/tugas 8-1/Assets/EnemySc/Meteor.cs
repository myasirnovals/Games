using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : Enemy
{
    public override void HurtSequence()
    {
        Debug.Log("Meteor terkena serangan!");
    }

    public override void DeathSequence()
    {
        Debug.Log("Meteor Meledak!");
        base.DeathSequence();
    }
}