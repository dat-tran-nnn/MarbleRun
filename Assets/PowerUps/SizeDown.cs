using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeDown : PowerUp
{
    public override void Activate(Collision collision)
    {
        collision.transform.localScale = new Vector3(ScaleDownSize,ScaleDownSize,ScaleDownSize);
    }
}
