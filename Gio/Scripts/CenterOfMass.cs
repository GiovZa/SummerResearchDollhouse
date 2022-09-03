using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Stolen by Gio from YouTube video https://www.youtube.com/watch?v=n2VOu5d2wVM&ab_channel=DitzelGames
//Added to allow objects to not fall sideways, with Center of Mass at "feet" of object, it will (almost) always land upright

[RequireComponent(typeof(Rigidbody))]
public class CenterOfMass : MonoBehaviour
{
    public Vector3 CenterOfMass2;

    public bool Awake;
    protected Rigidbody r;

    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        r.centerOfMass = CenterOfMass2;
        r.WakeUp();
        Awake = !r.IsSleeping();
        //Changes rigidbody's center of mass to CenterOfMass2 with position set by user in prefab
        //Then, sets it to active or not depending on if Awake boolean is active or not
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawSphere(transform.position + transform.rotation * CenterOfMass2, 0.1f);
        // makes sphere so you can see where CenterofMass2 will be
    }
}