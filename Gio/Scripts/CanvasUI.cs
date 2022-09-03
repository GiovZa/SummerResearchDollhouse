// Code modified from InventoryVR.cs by Gio
// Made to have main canvas move with player so that it is portable
// In UIHelpers -> EventSystem

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasUI : MonoBehaviour
{
    public GameObject Anchor;
    bool UIActive;
    public int counter;

    private void Start()
    {
        UIActive = false;
        // set to off at start, mostly to make sure octadehron default doesn't conflict with canvasUI.cs
    }

    private void Update()
    {
        DollhouseProgramUI activeUI = DollhouseProgram.GetActiveProgramUI();
        //gets unique component from Vanderhyde's code
        if (activeUI != null)
            //makes it so if activeUI fails to set, code doesn't run 
        {
            GameObject Inventory = activeUI.transform.parent.gameObject;
            // gets specific canvas for coding from the unique component set earlier to activeUI, then sets it to Inventory variable from InventoryVR.cs
            if (OVRInput.GetDown(OVRInput.Button.Two))
                // when B button is pressed, do the following:
            {
                UIActive = !UIActive;
                // sets UIActive bool to true if false, and false if true
                Inventory.SetActive(UIActive);
                // activates or deactivates Inventory (just canvas set in InventoryVR.cs) dependig on UIActive's boolean value
                if (UIActive == true)
                {
                    counter += 1;
                    // When canvas is active, add 1 to counter
                }
            }
            if (UIActive == true)
            {
                if (counter % 2 == 0)
                    // if counter is even (meaning UIActive has been switched on an even number of times), then ...
                {
                    Inventory.transform.SetPositionAndRotation(Anchor.transform.position, Anchor.transform.rotation);
                    // ... Have canvas follow anchor, which is set to a transform placed in front of center view for VR user
                }
            }
        }
    }
}
