using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freez : PickUp
{
    public int freez = 10;
    public override void Picked()
    {
        GameManager.instance.FreezTime(freez);
        base.Picked();
    }


    void Update()
    {
        Rotation();
    }
}
