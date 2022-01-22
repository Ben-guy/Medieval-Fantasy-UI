using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class BackInput : MonoBehaviour
{
    [SerializeField]private Button wantedButton;

    UIScript uiScript;
    private PlayerControls controller;
    private InputAction Action;

    private void Awake()
    {
        controller = new PlayerControls();
    }

    private void Start()
    {
        uiScript = FindObjectOfType<UIScript>();
    }

    private void OnEnable()
    {
        Action = controller.UIControls.Back;
        Action.Enable();

        controller.UIControls.Back.performed += backInput;
        controller.UIControls.Back.Enable();
    }

    private void OnDisable()
    {
        Action.Disable();
        controller.UIControls.Back.Disable();
    }
    private void backInput(InputAction.CallbackContext obj)
    {
        uiScript.selectButtion(wantedButton);
    }

}
