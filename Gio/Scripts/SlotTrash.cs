using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


// Script modified by Gio from original Slot.cs made by RealaryVR, rewritten to destroy GameObject as a trash slot rather than an inventory one

public class SlotTrash : MonoBehaviour
{
    public GameObject ItemInSlot;
    public Image slotImage;
    Color originalColor;

    void Start()
    {
        slotImage = GetComponentInChildren<Image>();
        originalColor = slotImage.color;
        // Sets trash icon 
    }

    private void OnTriggerStay(Collider other)
    {
        if (ItemInSlot != null) return;
        GameObject obj = other.gameObject;
        if (!IsItem(obj)) return;
        GetComponentInChildren<Image>().color = new Color32(255, 0, 0, 255);
        // Checks if object has Item script that makes it deletable, then changes color to red to notify user that item will be deleted

        if (OVRInput.GetUp(OVRInput.Button.SecondaryHandTrigger))
        {
            DeleteItem(obj);
            // if in collision and controller trigger is let go, DeleteItem function is called
        }

    }
    private void OnTriggerExit(Collider other)
    {
        GetComponentInChildren<Image>().color = originalColor;
        // Changes color to white if object is no longer in collider

    }

    bool IsItem(GameObject obj)
    {
        return obj.GetComponent<Item>();
        //checks if object has item.cs
    }

    void DeleteItem(GameObject obj)
    { 
        // if string of guid is in object, don't allow delete
        Destroy(obj);
        GetComponentInChildren<Image>().color = new Color32(0, 0, 255, 255);
        //Deletes object from world, and sets trash icon to blue to notifiy successful deletion
    }
}
