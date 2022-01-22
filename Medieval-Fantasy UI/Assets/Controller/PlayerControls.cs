// GENERATED AUTOMATICALLY FROM 'Assets/Controller/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""UIControls"",
            ""id"": ""37b0a668-094a-4780-b592-dc5844cc9972"",
            ""actions"": [
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""c3018906-bbc3-4e6b-aba9-4668ce7466ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Button"",
                    ""id"": ""0b963bab-1bed-4e56-925b-37f9f2b31764"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a4f5b80a-56b9-4cfe-83ec-afe49ab9581e"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00468ad8-b116-4957-874d-1c48c5f56ffe"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e8add8a-083e-4022-bc8f-71f48b7c88cc"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34e22511-2c96-4067-bd8d-957cb772f84c"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf659156-9c67-40e0-bcdc-856f14095c33"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // UIControls
        m_UIControls = asset.FindActionMap("UIControls", throwIfNotFound: true);
        m_UIControls_Back = m_UIControls.FindAction("Back", throwIfNotFound: true);
        m_UIControls_Vertical = m_UIControls.FindAction("Vertical", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // UIControls
    private readonly InputActionMap m_UIControls;
    private IUIControlsActions m_UIControlsActionsCallbackInterface;
    private readonly InputAction m_UIControls_Back;
    private readonly InputAction m_UIControls_Vertical;
    public struct UIControlsActions
    {
        private @PlayerControls m_Wrapper;
        public UIControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Back => m_Wrapper.m_UIControls_Back;
        public InputAction @Vertical => m_Wrapper.m_UIControls_Vertical;
        public InputActionMap Get() { return m_Wrapper.m_UIControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIControlsActions set) { return set.Get(); }
        public void SetCallbacks(IUIControlsActions instance)
        {
            if (m_Wrapper.m_UIControlsActionsCallbackInterface != null)
            {
                @Back.started -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnBack;
                @Vertical.started -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_UIControlsActionsCallbackInterface.OnVertical;
            }
            m_Wrapper.m_UIControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
            }
        }
    }
    public UIControlsActions @UIControls => new UIControlsActions(this);
    public interface IUIControlsActions
    {
        void OnBack(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
    }
}
