using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    public GameObject door;
    public GameObject KeyPoofPrefab;

    public GameObject key;

    public GameObject wallToBeDestroyed;

	public void OnKeyClicked()

	{
        Instantiate(KeyPoofPrefab,transform.position,Quaternion.Euler(-90,0,0));
        var openDoor = door.GetComponent<Door>();
        openDoor.Unlock();
        Destroy(wallToBeDestroyed);
        Destroy(key);
        
    }

}
