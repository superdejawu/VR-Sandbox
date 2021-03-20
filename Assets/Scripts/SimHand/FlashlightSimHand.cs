﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightSimHand : GrabbableObjectSimHand
{
    public Light flashLight;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(isBeingHeld)
        {

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Interact();
            }
          
        }
    }

    public void Interact()
    {
        flashLight.enabled = !flashLight.enabled;
    }
}
