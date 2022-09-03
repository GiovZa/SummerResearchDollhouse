using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layerChange : MonoBehaviour
{
    /*private int countsPriv;
    public void Start()
    {
        countsPriv = GameObject.Find("OVRPlayerController").GetComponent<OVRPlayerController>().counts;
        // Gets public int counts from OVRPlayerController
        if (countsPriv % 2 == 0)
        {
            gameObject.layer = 6;
            // Since counts = 0 at start of program, all gameObjects with this script will be placed in grabbable layer when scene loads
            // If all objects are in grabbable layer currently, new object that gets spawned from gallery will also be in gallery
        }
        if (countsPriv % 2 == 1)
        {
            gameObject.layer = 0;
            // Otherwise, all gameObjects must be in code mode/default layer, and so this object will too be in code mode
        }
    }
    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
            // if the X button on right hand controller is pressed
        {
            if (gameObject.layer == 6)
            {
                gameObject.layer = 0;
                return;
            }
            // if item with layerChange.cs is in grabbable layer, swap to default layer (which allows Vanderhyde's Dollhouse/Mal code to work on objects)

            if (gameObject.layer == 0)
            {
                gameObject.layer = 6;
                return;
            }
            // if item with layerChange.cs is in default layer, swap to Grabbable layer (which allows Gio's / Oculus distance grab code to work on objects)
        }
    } */

    // Until a sure way of making objects the same layers always, using two buttons, one for each layer, will be the default
    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            gameObject.layer = 6;
        }
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            gameObject.layer = 0;

        }
    }
}
// Made by Gio 
// Purpose: swap between being able to grab things and being able to code them