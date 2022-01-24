using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class BackToMenu : MonoBehaviour
{
    [SerializeField] private Button wantedButton;
    [SerializeField] private GameObject wantedMenu;
    [SerializeField] private GameObject[] unwantedMenus;
    [SerializeField] private Transform navigationBar;

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

        controller.UIControls.Back.performed += backToMenu;
        controller.UIControls.Back.Enable();
    }

    private void OnDisable()
    {
        Action.Disable();
        controller.UIControls.Back.Disable();
    }

    private void backToMenu(InputAction.CallbackContext obj)
    {
        for (int i = 0; i < unwantedMenus.Length; i++)
        {
            unwantedMenus[i].SetActive(false);
        }

        float postionX = 150f;
        navigationBar.localPosition = new Vector3(postionX, 0, 0);
        //navigationBar.gameObject.SetActive(false);

        wantedMenu.SetActive(true);
        uiScript.selectButtion(wantedButton);
    }

}
