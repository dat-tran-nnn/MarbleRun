using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeUp : PowerUp
{

    public override void Activate(Collision collision)
    {
        collision.transform.localScale = new Vector3(scaleUpSize, scaleUpSize, scaleUpSize);
    }
}
