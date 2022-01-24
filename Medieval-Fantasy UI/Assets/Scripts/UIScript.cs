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

    public void selectInputField(InputField wantedInputField)
    {
        wantedInputField.Select();
    }

    public void selectedSlider(Slider wantedSlider)
    {
        wantedSlider.Select();
    }
    public void cameraRotateX(float x)
    {

    }
    public void moveMenuIn(Transform Menu)
    {
        float postionX = 150f;
        Menu.localPosition = new Vector3(postionX, 0, 0);
    }
    public void moveMenuOut(Transform Menu)
    {
        float postionX = 25;
        Menu.localPosition = new Vector3(postionX, 0, 0);
    }
}
