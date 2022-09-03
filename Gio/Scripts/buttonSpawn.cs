using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonSpawn : MonoBehaviour
{
    public Transform spawnPoint;
    // spawns item in Transfrom set above

   public void Spawner(GameObject obj)
    {
        GameObject.Find("World").GetComponent<SaveLoad>().Load("(list (create-entity {:gallery-name \"" + 
            obj.GetComponent<GalleryItem>().galleryItemName + "\", :transform [" + spawnPoint.position.x + " " + spawnPoint.position.y + " " + spawnPoint.position.z + " " 
            + spawnPoint.rotation.x + " " + spawnPoint.rotation.y + " " + spawnPoint.rotation.z + " 1 1 1]}))");
    }
}
// Code made by Gio and Dr.Vanderhyde to allow buttons to spawn chosen gameObject into scene when pressed
// In World -> ButtonControllerSpawner