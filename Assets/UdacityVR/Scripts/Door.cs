﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    public bool locked = true;
    public bool opening = false;

    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 

    void Update() {
        // If the door is opening and it is not fully raised
            // Animate the door raising up
    }

    public void OnDoorClicked() {
        if(locked == false)
        {
            opening = true;
        }
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
    }

    public void Unlock()
    {
        locked = false;
    }
}
