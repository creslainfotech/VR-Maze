using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    public GameObject door;
    public GameObject KeyPoofPrefab;

    public GameObject key;

    public GameObject wallToBeDestroyed;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()

	{
        Instantiate(KeyPoofPrefab,transform.position,Quaternion.Euler(-90,0,0));
        var openDoor = door.GetComponent<Door>();
        openDoor.Unlock();
        Destroy(wallToBeDestroyed);
        Destroy(key);
        // Set the Key Collected Variable to true
        
    }

}
