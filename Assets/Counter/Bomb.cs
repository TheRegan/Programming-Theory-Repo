using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Bomb : CatchableObject
{
    [SerializeField] private GameObject particles;

    //POLYMORPHISM
    public override void CaughtObject()
    {
        Instantiate(particles, transform.position, Quaternion.identity);
        base.CaughtObject();
    }
}
