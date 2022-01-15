using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System;

public class UIScript : MonoBehaviour
{
    public void selectButtion (Button wantedButton)
    {
        wantedButton.Select();
    }

    public void selectDropdown(Dropdown wantedDropdown)
    {
        wantedDropdown.Select();
    }

}
