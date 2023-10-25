using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : PowerUp
{
    public override void Activate(Collision collision)
    {
        Rigidbody rb = collision.rigidbody;

        if (rb != null)
        {
            rb.velocity *= speed;
        }
    }
}
